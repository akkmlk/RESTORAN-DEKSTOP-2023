Imports System.Data.SqlClient
Module ModuleKelontongan
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public MyDB As String
    Public Sub koneksi()
        MyDB = "Data Source = DESKTOP-RDF8783\SQLEXPRESS; initial catalog = db_kelontong; integrated security = true"
        conn = New SqlConnection(MyDB)
        If conn.State = conn.State.Closed Then conn.Open()
    End Sub
End Module
