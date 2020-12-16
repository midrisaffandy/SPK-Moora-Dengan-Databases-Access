Imports System.Data.OleDb
Public Class FormLogin

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BukaKoneksi()
        txtuser.Text = ""
        txtpass.Text = ""
        txtuser.Focus()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim sql As String = "SELECT * FROM Login WHERE Username='" & txtuser.Text & _
           "' and password='" & txtpass.Text & "'"
        Dim dr As OleDbDataReader = New OleDbCommand(sql, Cn).ExecuteReader
        If dr.HasRows Then
            txtuser.Text = ""
            txtpass.Text = ""
            txtuser.Focus()
            Me.Hide()
            FormUtama.Show()
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Login")
        Else
            MsgBox("Login Gagal", MsgBoxStyle.Critical, "Login")
            txtuser.Text = ""
            txtpass.Text = ""
            txtuser.Focus()
        End If
        dr.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub
End Class
