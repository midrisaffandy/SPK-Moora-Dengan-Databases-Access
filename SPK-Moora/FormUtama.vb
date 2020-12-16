Public Class FormUtama

    Private Sub DataAlternatifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAlternatifToolStripMenuItem.Click
        FormDataAlternatif.Show()
    End Sub

    Private Sub DataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKriteriaToolStripMenuItem.Click
        FormDataKriteria.Show()
    End Sub

    Private Sub PerhitunganMooraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerhitunganMooraToolStripMenuItem.Click
        FormPerhitungan.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim konfirmasi As String
        konfirmasi = MsgBox("Anda Yakin Ingin Keluar Dari Aplikasi Ini?", vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Me.Close()
            FormLogin.Show()
        End If
    End Sub

End Class