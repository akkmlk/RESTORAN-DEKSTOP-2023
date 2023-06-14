Imports System.Data.SqlClient
Public Class FormAdmin
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        Call munculGrid()
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("SELECT  Idlog AS IdLog, TblUser.Username AS Username, Waktu AS Waktu, Aktifitas AS Aktivitas FROM TblLog JOIN TblUser ON IdUserr =  TblUser.IdUser ORDER BY Waktu", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "log")
        dgv.DataSource = ds.Tables("log")
        dgv.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim day, month, year As String

        day = Format(DateTimePicker1.Value, "dd")
        month = Format(DateTimePicker1.Value, "MM")
        year = Format(DateTimePicker1.Value, "yyyy")

        Call koneksi()
        da = New SqlDataAdapter("SELECT  Idlog AS IdLog, TblUser.Username AS Username, Waktu AS Waktu, Aktifitas AS Aktivitas FROM TblLog JOIN TblUser ON IdUserr =  TblUser.IdUser WHERE DAY (Waktu) = '" & day & "' AND MONTH (Waktu) = '" & month & "' AND YEAR (Waktu) = '" & year & "' ORDER BY Waktu", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "ketemu")
        dgv.DataSource = ds.Tables("ketemu")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormUser.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FormLaporan.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim quest As String = MessageBox.Show("Yakin Mau Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quest = vbYes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call kondisiAwal()
    End Sub
End Class