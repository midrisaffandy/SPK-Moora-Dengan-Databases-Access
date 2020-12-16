Imports System.Data.OleDb
Public Class FormDataAlternatif

    Sub TampilData()
        On Error Resume Next
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("SELECT * FROM Kriteria", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    LVKriteria.Items.Clear()
                    While Data.Read
                        LVKriteria.Items.Add(Data("Nama"))
                        LVKriteria.Items(x).SubItems.Add(Data("Bobot"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("SELECT * FROM Alternatif ORDER BY ID ASC", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    LV.Items.Clear()
                    While Data.Read
                        LV.Items.Add(x + 1)
                        LV.Items(x).SubItems.Add(Data("ID"))
                        LV.Items(x).SubItems.Add(Data("Nama"))
                        LV.Items(x).SubItems.Add(Data("c1"))
                        LV.Items(x).SubItems.Add(Data("c2"))
                        LV.Items(x).SubItems.Add(Data("c3"))
                        LV.Items(x).SubItems.Add(Data("c4"))
                        LV.Items(x).SubItems.Add(Data("c5"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    Sub bersihdata()
        txtid.Text = ""
        txtnama.Clear()
        cbkepemimpinan.Text = ""
        cbpendapatan.Text = ""
        cbtenaga.Text = ""
        cbefektivitas.Text = ""
        cbjenis.Text = ""
    End Sub

    Sub aktif()
        txtid.Enabled = True
        txtnama.Enabled = True
        cbkepemimpinan.Enabled = True
        cbpendapatan.Enabled = True
        cbtenaga.Enabled = True
        cbefektivitas.Enabled = True
        cbjenis.Enabled = True
    End Sub

    Sub tidakaktif()
        txtid.Enabled = False
        txtnama.Enabled = False
        cbkepemimpinan.Enabled = False
        cbpendapatan.Enabled = False
        cbtenaga.Enabled = False
        cbefektivitas.Enabled = False
        cbjenis.Enabled = False
    End Sub

    Sub tidakaktifnilai()
        txtkepemimpinan.Enabled = False
        txtpendapatan.Enabled = False
        txttenaga.Enabled = False
        txtefektivitas.Enabled = False
        txtjenis.Enabled = False
    End Sub

    Sub bersihnilai()
        txtkepemimpinan.Text = 0
        txtpendapatan.Text = 0
        txttenaga.Text = 0
        txtefektivitas.Text = 0
        txtjenis.Text = 0
    End Sub

    Sub Autonumber()
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("SELECT * FROM Alternatif WHERE ID in(SELECT MAX(ID) FROM Alternatif) ORDER BY ID", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim urut As String
                    Dim hitung As Long
                    Data.Read()
                    With Data
                        If Not Data.HasRows Then
                            urut = "A" + "01"
                            txtid.Text = urut
                        Else
                            hitung = Microsoft.VisualBasic.Right(Data.GetString(0), 2) + 1
                            urut = "A" + Microsoft.VisualBasic.Right("00" & hitung, 2)
                        End If
                        txtid.Text = urut
                        txtid.Enabled = False
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub FormAlternatif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersihdata()
        Call TampilData()
        Call tidakaktif()
        Call tidakaktifnilai()
    End Sub

    Private Sub cbkepemimpinan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkepemimpinan.SelectedIndexChanged
        If cbkepemimpinan.Text = "Sangat Baik" Then
            txtkepemimpinan.Text = 5
            txtkepemimpinan.Enabled = False
        ElseIf cbkepemimpinan.Text = "Baik" Then
            txtkepemimpinan.Text = 4
            txtkepemimpinan.Enabled = False
        ElseIf cbkepemimpinan.Text = "Cukup Baik" Then
            txtkepemimpinan.Text = 3
            txtkepemimpinan.Enabled = False
        ElseIf cbkepemimpinan.Text = "Buruk" Then
            txtkepemimpinan.Text = 2
            txtkepemimpinan.Enabled = False
        ElseIf cbkepemimpinan.Text = "Sangat Buruk" Then
            txtkepemimpinan.Text = 1
            txtkepemimpinan.Enabled = False
        End If
    End Sub

    Private Sub cbpendapatan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpendapatan.SelectedIndexChanged
        If cbpendapatan.Text = ">Rp 5.000.000" Then
            txtpendapatan.Text = 5
            txtpendapatan.Enabled = False
        ElseIf cbpendapatan.Text = "≥Rp 4.000.000 – Rp 5.000.000" Then
            txtpendapatan.Text = 4
            txtpendapatan.Enabled = False
        ElseIf cbpendapatan.Text = "≥Rp 3.000.000 – Rp 3.900.000" Then
            txtpendapatan.Text = 3
            txtpendapatan.Enabled = False
        ElseIf cbpendapatan.Text = "≥Rp 2.000.000 – Rp 2.900.000" Then
            txtpendapatan.Text = 2
            txtpendapatan.Enabled = False
        ElseIf cbpendapatan.Text = "< Rp 2.000.000" Then
            txtpendapatan.Text = 1
            txtpendapatan.Enabled = False
        End If
    End Sub

    Private Sub cbtenaga_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtenaga.SelectedIndexChanged
        If cbtenaga.Text = "Sangat Memadai" Then
            txttenaga.Text = 5
            txttenaga.Enabled = False
        ElseIf cbtenaga.Text = "Memadai" Then
            txttenaga.Text = 4
            txttenaga.Enabled = False
        ElseIf cbtenaga.Text = "Cukup Memadai" Then
            txttenaga.Text = 3
            txttenaga.Enabled = False
        ElseIf cbtenaga.Text = "Kurang Memadai" Then
            txttenaga.Text = 2
            txttenaga.Enabled = False
        ElseIf cbtenaga.Text = "Sangat Kurang Memadai" Then
            txttenaga.Text = 1
            txttenaga.Enabled = False
        End If
    End Sub

    Private Sub cbefektivitas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbefektivitas.SelectedIndexChanged
        If cbefektivitas.Text = "Sangat Baik" Then
            txtefektivitas.Text = 5
            txtefektivitas.Enabled = False
        ElseIf cbefektivitas.Text = "Baik" Then
            txtefektivitas.Text = 4
            txtefektivitas.Enabled = False
        ElseIf cbefektivitas.Text = "Cukup Baik" Then
            txtefektivitas.Text = 3
            txtefektivitas.Enabled = False
        ElseIf cbefektivitas.Text = "Buruk" Then
            txtefektivitas.Text = 2
            txtefektivitas.Enabled = False
        ElseIf cbefektivitas.Text = "Sangat Buruk" Then
            txtefektivitas.Text = 1
            txtefektivitas.Enabled = False
        End If
    End Sub

    Private Sub cbjenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbjenis.SelectedIndexChanged
        If cbjenis.Text = "Simpan Pinjam" Then
            txtjenis.Text = 5
            txtjenis.Enabled = False
        ElseIf cbjenis.Text = "Peternakan" Then
            txtjenis.Text = 4
            txtjenis.Enabled = False
        ElseIf cbjenis.Text = "Bumdesmart" Then
            txtjenis.Text = 3
            txtjenis.Enabled = False
        ElseIf cbjenis.Text = "Modal Pertanian" Then
            txtjenis.Text = 2
            txtjenis.Enabled = False
        ElseIf cbjenis.Text = "Alat Pesta" Then
            txtjenis.Text = 1
            txtjenis.Enabled = False
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        If btntambah.Text = "TAMBAH" Then
            btntambah.Text = "SIMPAN"
            Call aktif()
            Call bersihdata()
            Call Autonumber()
            txtnama.Focus()
            btnbatal.Enabled = True
        Else
            If btntambah.Text = "SIMPAN" Then
                Try
                    If txtid.Text = "" Or txtnama.Text = "" Or cbkepemimpinan.Text = "" Or cbpendapatan.Text = "" Or cbtenaga.Text = "" Or cbefektivitas.Text = "" Or cbjenis.Text = "" Then
                        MsgBox("Data Belum Lengkap, Periksa Kembali.!", MsgBoxStyle.Information, "Informasi")
                        txtid.Focus()
                    Else
                        Using koneksi As New OleDbConnection(Database)
                            Using Cmd As New OleDbCommand("INSERT INTO Alternatif VALUES('" & _
                                                           txtid.Text & "','" & _
                                                           txtnama.Text & "','" & _
                                                           cbkepemimpinan.Text & "','" & _
                                                           cbpendapatan.Text & "','" & _
                                                           cbtenaga.Text & "','" & _
                                                           cbefektivitas.Text & "','" & _
                                                           cbjenis.Text & "')", koneksi)
                                koneksi.Open()
                                Cmd.CommandType = CommandType.Text
                                Cmd.ExecuteNonQuery()
                                MsgBox("Data " & txtnama.Text & " Berhasil Disimpan")
                                Call TampilData()
                                Call bersihdata()
                                btntambah.Text = "TAMBAH"
                            End Using
                        End Using
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message())
                End Try
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call bersihdata()
        Call tidakaktif()
        Call bersihnilai()
        btntambah.Enabled = True
        btntambah.Text = "TAMBAH"
        btnubah.Enabled = False
        btnhapus.Enabled = False
        btnbatal.Enabled = False
    End Sub

    Private Sub LV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.Click
        Call aktif()
        txtid.Text = LV.SelectedItems(0).SubItems(1).Text.ToString
        txtnama.Text = LV.SelectedItems(0).SubItems(2).Text.ToString
        cbkepemimpinan.Text = LV.SelectedItems(0).SubItems(3).Text.ToString
        cbpendapatan.Text = LV.SelectedItems(0).SubItems(4).Text.ToString
        cbtenaga.Text = LV.SelectedItems(0).SubItems(5).Text.ToString
        cbefektivitas.Text = LV.SelectedItems(0).SubItems(6).Text.ToString
        cbjenis.Text = LV.SelectedItems(0).SubItems(7).Text.ToString
        txtid.Enabled = False
        btntambah.Enabled = False
        btnbatal.Enabled = True
        btnubah.Enabled = True
        btnhapus.Enabled = True
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Try
            Using Koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("UPDATE Alternatif SET Nama='" & txtnama.Text & _
                                                                     "',c1='" & cbkepemimpinan.Text & _
                                                                     "',c2='" & cbpendapatan.Text & _
                                                                     "',c3='" & cbtenaga.Text & _
                                                                     "',c4='" & cbefektivitas.Text & _
                                                                     "',c5='" & cbjenis.Text & _
                                                                     "' where ID='" & txtid.Text & "'", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("Perubahan Data Berhasil", MsgBoxStyle.Information)
            Call TampilData()
            Call tidakaktif()
            Call bersihdata()
            btntambah.Enabled = True
            btnubah.Enabled = False
            btnhapus.Enabled = False
            btnbatal.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim konfirmasi As String
        konfirmasi = MsgBox("Anda Yakin Ingin Menghapus Data " & txtnama.Text & " ...?", vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Try
                Using Koneksi As New OleDbConnection(Database)
                    Using Cmd As New OleDbCommand("DELETE * FROM Alternatif WHERE ID ='" & txtid.Text & "'", Koneksi)
                        Koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()
                    End Using
                End Using
                Call TampilData()
                Call tidakaktif()
                Call bersihdata()
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information)
                btntambah.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                btnbatal.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        Else
            bersihdata()
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Call bersihdata()
        Me.Close()
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("SELECT * FROM Alternatif WHERE Nama Like '" & txtcari.Text & "%'", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    LV.Items.Clear()
                    While Data.Read
                        LV.Items.Add(x + 1)
                        LV.Items(x).SubItems.Add(Data("ID"))
                        LV.Items(x).SubItems.Add(Data("Nama"))
                        LV.Items(x).SubItems.Add(Data("c1"))
                        LV.Items(x).SubItems.Add(Data("c2"))
                        LV.Items(x).SubItems.Add(Data("c3"))
                        LV.Items(x).SubItems.Add(Data("c4"))
                        LV.Items(x).SubItems.Add(Data("c5"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class