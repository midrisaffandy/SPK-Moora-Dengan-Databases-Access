Imports System.Data.OleDb
Public Class FormPerhitungan

    Dim m1 As Decimal = 0
    Dim m2 As Decimal = 0
    Dim m3 As Decimal = 0
    Dim m4 As Decimal = 0
    Dim m5 As Decimal = 0
    Dim KINERJA_C1 As Decimal
    Dim KINERJA_C2 As Decimal
    Dim KINERJA_C3 As Decimal
    Dim KINERJA_C4 As Decimal
    Dim KINERJA_C5 As Decimal
    Dim bobot1, bobot2, bobot3, bobot4, bobot5 As Decimal

    Sub TampilData()
        On Error Resume Next
        'Untuk mengetahui nilai benefit dan cost
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Kriteria order by kode asc ", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    Dim s As Integer
                    ListView1.Items.Clear()
                    While Data.Read
                        If Data("Jenis") = "Benefit" Then
                            s = 1
                        Else
                            s = -1
                        End If

                        If Data("Kode") = "C1" Then
                            bobot1 = s * (Data("Bobot"))
                        ElseIf Data("Kode") = "C2" Then
                            bobot2 = s * (Data("Bobot"))
                        ElseIf Data("Kode") = "C3" Then
                            bobot3 = s * (Data("Bobot"))
                        ElseIf Data("Kode") = "C4" Then
                            bobot4 = s * (Data("Bobot"))
                        ElseIf Data("Kode") = "C5" Then
                            bobot5 = s * (Data("Bobot"))
                        End If
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
        'Algoritma Ke 2 = Merubah Nilai Kriteria Menjadi Matriks Keputusan
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Alternatif order by ID asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(Data("ID"))
                        ListView1.Items(x).SubItems.Add(Data("Nama"))

                        Dim c1 As Integer
                        If Data("c1") = "Sangat Baik" Then
                            c1 = 5
                        ElseIf Data("c1") = "Baik" Then
                            c1 = 4
                        ElseIf Data("c1") = "Cukup Baik" Then
                            c1 = 3
                        ElseIf Data("c1") = "Buruk" Then
                            c1 = 2
                        ElseIf Data("c1") = "Sangat Buruk" Then
                            c1 = 1
                        End If
                        ListView1.Items(x).SubItems.Add(c1)

                        Dim c2 As Integer
                        If Data("c2") = ">Rp 5.000.000" Then
                            c2 = 5
                        ElseIf Data("c2") = "≥Rp 4.000.000 – Rp 5.000.000" Then
                            c2 = 4
                        ElseIf Data("c2") = "≥Rp 3.000.000 – Rp 3.900.000" Then
                            c2 = 3
                        ElseIf Data("c2") = "≥Rp 2.000.000 – Rp 2.900.000" Then
                            c2 = 2
                        ElseIf Data("c2") = "< Rp 2.000.000" Then
                            c2 = 1
                        End If
                        ListView1.Items(x).SubItems.Add(c2)

                        Dim c3 As Integer
                        If Data("c3") = "Sangat Memadai" Then
                            c3 = 5
                        ElseIf Data("c3") = "Memadai" Then
                            c3 = 4
                        ElseIf Data("c3") = "Cukup Memadai" Then
                            c3 = 3
                        ElseIf Data("c3") = "Kurang Memadai" Then
                            c3 = 2
                        ElseIf Data("c3") = "Sangat Kurang Memadai" Then
                            c3 = 1
                        End If
                        ListView1.Items(x).SubItems.Add(c3)

                        Dim c4 As Integer
                        If Data("c4") = "Sangat Baik" Then
                            c4 = 5
                        ElseIf Data("c4") = "Baik" Then
                            c4 = 4
                        ElseIf Data("c4") = "Cukup Baik" Then
                            c4 = 3
                        ElseIf Data("c4") = "Buruk" Then
                            c4 = 2
                        ElseIf Data("c4") = "Sangat Buruk" Then
                            c4 = 1
                        End If
                        ListView1.Items(x).SubItems.Add(c4)

                        Dim c5 As Integer
                        If Data("c5") = "Simpan Pinjam" Then
                            c5 = 5
                        ElseIf Data("c5") = "Peternakan" Then
                            c5 = 4
                        ElseIf Data("c5") = "Bumdesmart" Then
                            c5 = 3
                        ElseIf Data("c5") = "Modal Pertanian" Then
                            c5 = 2
                        ElseIf Data("c5") = "Alat Pesta" Then
                            c5 = 1
                        End If
                        ListView1.Items(x).SubItems.Add(c5)

                        x = x + 1
                        m1 = m1 + (c1 ^ 2)
                        m2 = m2 + (c2 ^ 2)
                        m3 = m3 + (c3 ^ 2)
                        m4 = m4 + (c4 ^ 2)
                        m5 = m5 + (c5 ^ 2)

                    End While
                End Using
            End Using
        End Using
        'Hasil Nilai matrik ternormalisasi yang diakarkan
        'kenapa 0.5 karna akar itu sama dengan 0.5
        KINERJA_C1 = m1 ^ 0.5
        KINERJA_C2 = m2 ^ 0.5
        KINERJA_C3 = m3 ^ 0.5
        KINERJA_C4 = m4 ^ 0.5
        KINERJA_C5 = m5 ^ 0.5
    End Sub

    Private Sub FormPerhitungan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        ListView2.Items.Clear()
        ListView3.Items.Clear()
        ListView4.Items.Clear()

        For i = 0 To ListView1.Items.Count - 1
            ListView2.Items.Add(ListView1.Items(i).Text.ToString)
            ListView2.Items(i).SubItems.Add(ListView1.Items(i).SubItems(1).Text.ToString)
            ListView2.Items(i).SubItems.Add(FormatNumber(ListView1.Items(i).SubItems(2).Text.ToString / KINERJA_C1, 4))
            ListView2.Items(i).SubItems.Add(FormatNumber(ListView1.Items(i).SubItems(3).Text.ToString / KINERJA_C2, 4))
            ListView2.Items(i).SubItems.Add(FormatNumber(ListView1.Items(i).SubItems(4).Text.ToString / KINERJA_C3, 4))
            ListView2.Items(i).SubItems.Add(FormatNumber(ListView1.Items(i).SubItems(5).Text.ToString / KINERJA_C4, 4))
            ListView2.Items(i).SubItems.Add(FormatNumber(ListView1.Items(i).SubItems(6).Text.ToString / KINERJA_C5, 4))
        Next

        For i = 0 To ListView1.Items.Count - 1
            ListView3.Items.Add(ListView1.Items(i).Text.ToString)
            ListView3.Items(i).SubItems.Add(ListView1.Items(i).SubItems(1).Text.ToString)
            ListView3.Items(i).SubItems.Add(FormatNumber((ListView1.Items(i).SubItems(2).Text.ToString / KINERJA_C1) * bobot1, 4))
            ListView3.Items(i).SubItems.Add(FormatNumber((ListView1.Items(i).SubItems(3).Text.ToString / KINERJA_C2) * bobot2, 4))
            ListView3.Items(i).SubItems.Add(FormatNumber((ListView1.Items(i).SubItems(4).Text.ToString / KINERJA_C3) * bobot3, 4))
            ListView3.Items(i).SubItems.Add(FormatNumber((ListView1.Items(i).SubItems(5).Text.ToString / KINERJA_C4) * bobot4, 4))
            ListView3.Items(i).SubItems.Add(FormatNumber((ListView1.Items(i).SubItems(6).Text.ToString / KINERJA_C5) * bobot5, 4))
        Next

        Using Koneksi As New OleDbConnection(Database)
            Using Cmd As New OleDbCommand("delete * from hasil ", Koneksi)
                Koneksi.Open()
                Cmd.CommandType = CommandType.Text
                Cmd.ExecuteNonQuery()
            End Using
        End Using

        For i = 0 To ListView1.Items.Count - 1
            Dim c1 As Decimal = ListView3.Items(i).SubItems(2).Text.ToString
            Dim c2 As Decimal = ListView3.Items(i).SubItems(3).Text.ToString
            Dim c3 As Decimal = ListView3.Items(i).SubItems(4).Text.ToString
            Dim c4 As Decimal = ListView3.Items(i).SubItems(5).Text.ToString
            Dim c5 As Decimal = ListView3.Items(i).SubItems(6).Text.ToString
            Dim hasil As Decimal = c1 + c2 + c3 + c4 + c5
            'Aturan Alternatif untuk mencari nilai layak atau tidak


            'Konsep perangkingan adalah setiap data yang dihasilkan oleh perhitungan disimpan kedalam database
            'dan dipanggil kedalam listview dengan sort by nilai tertinggi. (urutan nilai tertinggi)

            Using koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("insert into hasil values('" & _
                                              ListView1.Items(i).SubItems(0).Text.ToString & "','" & _
                                              ListView1.Items(i).SubItems(1).Text.ToString & "','" & _
                                               FormatNumber((c1 + c2 + c3 + c4 + c5), 5) & "')", koneksi)
                    koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using

        Next
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from hasil order by Hasil desc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView4.Items.Clear()
                    While Data.Read
                        ListView4.Items.Add(x + 1)
                        ListView4.Items(x).SubItems.Add(Data("Kode"))
                        ListView4.Items(x).SubItems.Add(Data("Nama"))
                        ListView4.Items(x).SubItems.Add(Data("Hasil"))
                        Dim rank As String = "Rangking " & x + 1
                        ListView4.Items(x).SubItems.Add(rank)
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
        MsgBox("Berhasil Menghitung Perangkingan Dengan MOORA", MsgBoxStyle.Information, "Informasi")
        btnhitung.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class