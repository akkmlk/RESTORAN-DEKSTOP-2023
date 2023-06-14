Imports System.Data.SqlClient
Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        Button3.Enabled = False
        Chart1.Series("Omset").Points.Clear()
        Call munculGrid()
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("SELECT NoTransaksi AS NoTransaksi, TglTransaksi AS TanggalTransaksi, TotalBayar AS TotalPembayaran, TblUser.Nama AS NamaKasir FROM TblTransaksi JOIN TblUser ON IdUserr = TblUser.IdUser ORDER BY TglTransaksi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "laporan")
        dgv.DataSource = ds.Tables("laporan")
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim startD, startM, startY, endD, endM, endY As String
        Dim dari, sampai As String

        startD = Format(DateTimePicker1.Value, "dd")
        startM = Format(DateTimePicker1.Value, "MM")
        startY = Format(DateTimePicker1.Value, "yyyy")

        endD = Format(DateTimePicker2.Value, "dd")
        endM = Format(DateTimePicker2.Value, "MM")
        endY = Format(DateTimePicker2.Value, "yyyy")

        dari = startY & "-" & startM & "-" & startD
        sampai = endY & "-" & endM & "-" & endD

        Call koneksi()
        da = New SqlDataAdapter("SELECT NoTransaksi AS NoTransaksi, TglTransaksi AS TanggalTransaksi, TotalBayar AS TotalPembayaran, TblUser.Nama AS NamaKasir FROM TblTransaksi JOIN TblUser ON IdUserr = TblUser.IdUser WHERE TglTransaksi BETWEEN '" & dari & "' AND '" & sampai & "' ORDER BY TglTransaksi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "ketemu")
        dgv.DataSource = ds.Tables("ketemu")
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim startD, startM, startY, endD, endM, endY As String
        Dim dari, sampai As String

        startD = Format(DateTimePicker1.Value, "dd")
        startM = Format(DateTimePicker1.Value, "MM")
        startY = Format(DateTimePicker1.Value, "yyyy")

        endD = Format(DateTimePicker2.Value, "dd")
        endM = Format(DateTimePicker2.Value, "MM")
        endY = Format(DateTimePicker2.Value, "yyyy")

        dari = startY & "-" & startM & "-" & startD
        sampai = endY & "-" & endM & "-" & endD

        Call koneksi()
        cmd = New SqlCommand("SELECT NoTransaksi AS NoTransaksi, TglTransaksi AS TanggalTransaksi, TotalBayar AS TotalPembayaran, TblUser.Nama AS NamaKasir FROM TblTransaksi JOIN TblUser ON IdUserr = TblUser.IdUser WHERE TglTransaksi BETWEEN '" & dari & "' AND '" & sampai & "' ORDER BY TglTransaksi", conn)
        rd = cmd.ExecuteReader
        Chart1.Series("Omset").Points.Clear()

        While rd.Read
            Chart1.Series("Omset").Points.AddXY(Format(rd!TanggalTransaksi, "yyyy/MM/dd").ToString, rd!TotalPembayaran)
        End While
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call kondisiAwal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormUser.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim quest As String = MessageBox.Show("Yakin Ingin Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quest = vbYes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub
End Class