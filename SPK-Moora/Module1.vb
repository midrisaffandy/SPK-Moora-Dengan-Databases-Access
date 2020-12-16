Imports System.Data.OleDb
Module Module1
    Public Cn As New OleDbConnection
    Public StrCetak, Parameter As String
    Public objCommand As OleDb.OleDbCommand
    Public reader As OleDbDataReader
    Public Database As String = "Provider=Microsoft.jet.oledb.4.0; Data Source=" & Application.StartupPath & "\SPK-Moora.mdb"

    Public Cetak As String
    Public NmUser As String
    Public STRPTCR As String
    Public strSQL As String
    Public conect As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & Application.StartupPath & "\SPK-Moora.mdb")

    Public Function open() As OleDb.OleDbConnection
        Dim conect As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & Application.StartupPath & "\SPK-Moora.mdb")
        conect.Open()
        Return conect
    End Function

    Sub BukaKoneksi()
        Cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
        Application.StartupPath & "\SPK-Moora.mdb"
        Cn.Open()
    End Sub
End Module
