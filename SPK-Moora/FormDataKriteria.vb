Imports System.Data.OleDb
Public Class FormDataKriteria

    Sub TampilData()
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("SELECT * FROM Kriteria", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(x + 1)
                        ListView1.Items(x).SubItems.Add(Data("Kode"))
                        ListView1.Items(x).SubItems.Add(Data("Nama"))
                        ListView1.Items(x).SubItems.Add(Data("Bobot"))
                        ListView1.Items(x).SubItems.Add(Data("Jenis"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub

    Sub bersihdata()
        txtnama.Clear()
        txtbobot.Clear()
        txtkode.Clear()
        txtjenis.Text = ""
    End Sub

    Private Sub FormDataKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtkode.Enabled = False
        Call TampilData()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        On Error Resume Next
        txtkode.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        txtnama.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        txtbobot.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        txtjenis.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbobot.KeyPress
        If IsNumeric(e.KeyChar) = True OrElse e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Try
            Using Koneksi As New OleDbConnection(Database)
                Using Cmd As New OleDbCommand("UPDATE Kriteria SET Nama='" & txtnama.Text & _
                                                                     "',Bobot='" & txtbobot.Text & _
                                                                     "',Jenis='" & txtjenis.Text & _
                                                                     "' where Kode='" & txtkode.Text & "'", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("Perubahan Data Berhasil")
            Call TampilData()
            Call bersihdata()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call bersihdata()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

End Class