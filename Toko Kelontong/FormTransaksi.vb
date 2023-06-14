Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FormTransaksi
    Dim WithEvents PD As New PrintDocument
    Dim ppd As New PrintPreviewDialog
    Dim panjang As Integer
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        txtIdBrg.Text = ""
        txtKdBrg.Text = ""
        ComboBox1.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtTotal.Text = ""
        lblTotal.Text = ""
        lblKembalian.Text = ""
        lblTotalQty.Text = ""
        lblOk.Text = ""
        txtBayar.Text = ""
        txtNoTr.Visible = False
        txtIdBrg.Visible = False
        txtKdBrg.Visible = False
        txtIdUser.Visible = False
        lblOk.Visible = False
        lblTotalQty.Visible = False
        txtPrice.Enabled = False
        txtTotal.Enabled = False
        txtBayar.Enabled = False
        btnBayarPrint.Enabled = False
        btnSimpan.Enabled = False
        Call incrementNoTr()
        Call munculMenu()
        Call addColumnDgv()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        Call FormBarang.numberOnly(e)
    End Sub

    Sub incrementNoTr()
        Dim code As String
        Dim tgl As String = Format(Today, "yyyyMMdd")

        Call koneksi()
        cmd = New SqlCommand("SELECT NoTransaksi FROM TblTransaksi ORDER BY NoTransaksi DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            code = Microsoft.VisualBasic.Mid(rd!NoTransaksi, 11, 3) + 1
            If Len(code) = 1 Then
                code = "TR" & tgl & "00" & code
            ElseIf Len(code) = 2 Then
                code = "TR" & tgl & "0" & code
            ElseIf Len(code) = 3 Then
                code = "TR" & tgl & code
            End If
        Else
            code = "TR" & tgl & "001"
        End If
        txtNoTr.Text = code
    End Sub

    Sub munculMenu()
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TblBarang", conn)
        rd = cmd.ExecuteReader
        ComboBox1.Items.Clear()

        While rd.Read
            ComboBox1.Items.Add(rd!NamaBarang)
        End While
    End Sub

    Sub addColumnDgv()
        dgv.Columns.Clear()
        dgv.Columns.Add("notr", "No Transaksi")
        dgv.Columns.Add("kdbar", "Kode Barang")
        dgv.Columns.Add("nmbar", "Nama Barang")
        dgv.Columns.Add("prc", "Harga Satuan")
        dgv.Columns.Add("qty", "Quantitas")
        dgv.Columns.Add("subt", "Subtotal")
        dgv.Columns.Add("idus", "Id User")
        dgv.Columns.Add("idbar", "Id Barang")
        dgv.AllowUserToAddRows = False
        dgv.Columns("idus").Visible = False
        dgv.Columns("idbar").Visible = False
    End Sub

    Sub hitung()
        Dim totalBelanja, totalQty As Integer
        For i As Integer = 0 To dgv.RowCount - 1
            totalBelanja = totalBelanja + dgv.Rows(i).Cells("subt").Value
            totalQty = totalQty + dgv.Rows(i).Cells("qty").Value
            lblTotal.Text = totalBelanja
            lblTotalQty.Text = totalQty
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TblBarang WHERE NamaBarang = '" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtPrice.Text = rd!HargaSatuan
            txtIdBrg.Text = rd!IdBarang
            txtKdBrg.Text = rd!KodeBarang
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Dim total As Integer
        total = Val(txtPrice.Text) * Val(txtQty.Text)
        txtTotal.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtTotal.Text = "" Then
            MessageBox.Show("Kamu Belum Memilih Menu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtTotal.Text = "0" Then
                MessageBox.Show("Masukkan Berapa Jumlah Yang Ingin Dibeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If dgv.RowCount > 0 Then
                    MessageBox.Show("Keranjang Penuh, Silahkan Selesaikan Transaksi Sebelumnya Untuk Memesan Lagi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dgv.Rows.Add(New String() {txtNoTr.Text, txtKdBrg.Text, ComboBox1.Text, txtPrice.Text, txtQty.Text, txtTotal.Text, txtIdUser.Text, txtIdBrg.Text})
                    ComboBox1.Text = ""
                    txtPrice.Text = ""
                    txtQty.Text = ""
                    txtTotal.Text = ""
                    txtIdBrg.Text = ""
                    txtKdBrg.Text = ""
                    txtBayar.Enabled = True
                    btnBayarPrint.Enabled = True
                    txtBayar.Focus()
                    Call hitung()
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim quest As String = MessageBox.Show("Yakin Ingin Mengosongkan Keranjang?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quest = vbYes Then
            Call kondisiAwal()
        End If
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        Dim kembalin As Integer
        kembalin = Val(txtBayar.Text) - Val(lblTotal.Text)
        lblKembalian.Text = kembalin
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        Call FormBarang.numberOnly(e)
    End Sub

    Private Sub btnBayarPrint_Click(sender As Object, e As EventArgs) Handles btnBayarPrint.Click
        If Val(txtBayar.Text) < Val(lblTotal.Text) Then
            MessageBox.Show("Jumlah Bayar Kamu Kurang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call changeHeight()
            ppd.Document = PD
            ppd.ShowDialog()
            PD.Print()
            lblOk.Text = "Gas Simpan"
            btnSimpan.Enabled = True
        End If
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f14b As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim centerMargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2

        Dim center As New StringFormat
        center.Alignment = StringAlignment.Center

        Dim garis As String = "-------------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("FOOD XYZ", f14b, Brushes.Black, centerMargin, 5, center)
        e.Graphics.DrawString("Jl Raya No 2 Kota X", f10, Brushes.Black, centerMargin, 30, center)
        e.Graphics.DrawString("Hub : 0812 - 4769 - 3470", f10, Brushes.Black, centerMargin, 45, center)

        e.Graphics.DrawString("Nama Kasir", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 90, 60)
        e.Graphics.DrawString(kasirName.Text, f10, Brushes.Black, 100, 60)

        e.Graphics.DrawString("No Transaksi", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 90, 75)
        e.Graphics.DrawString(txtNoTr.Text, f10, Brushes.Black, 100, 75)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 90)

        Dim tinggi As Integer
        For i As Integer = 0 To dgv.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgv.Rows(i).Cells("qty").Value, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(i).Cells("nmbar").Value, f10, Brushes.Black, 100, 100 + tinggi)
            e.Graphics.DrawString(dgv.Rows(i).Cells("prc").Value, f10, Brushes.Black, 180, 100 + tinggi)
        Next

        tinggi = tinggi + 100
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 20 + tinggi)

        e.Graphics.DrawString(lblTotalQty.Text, f10, Brushes.Black, 0, 30 + tinggi)

        e.Graphics.DrawString("Total", f10, Brushes.Black, 0, 45 + tinggi)
        e.Graphics.DrawString(":", f10, Brushes.Black, 90, 45 + tinggi)
        e.Graphics.DrawString(lblTotal.Text, f10, Brushes.Black, 180, 45 + tinggi)

        e.Graphics.DrawString("Kembalian", f10, Brushes.Black, 0, 60 + tinggi)
        e.Graphics.DrawString(":", f10, Brushes.Black, 90, 60 + tinggi)
        e.Graphics.DrawString(lblKembalian.Text, f10, Brushes.Black, 180, 60 + tinggi)

        e.Graphics.DrawString("Food XYZ mengucapkan", f10, Brushes.Black, centerMargin, 85 + tinggi, center)
        e.Graphics.DrawString("Terima Kasih Sudah Berbelanja", f10, Brushes.Black, centerMargin, 105 + tinggi, center)
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pageSetup As New PageSettings
        pageSetup.PaperSize = New PaperSize("Custom", 250, panjang)
        PD.DefaultPageSettings = pageSetup
    End Sub

    Sub changeHeight()
        Dim rowcount As Integer
        rowcount = dgv.RowCount - 1

        panjang = 0
        panjang = rowcount * 15
        panjang = panjang + 300
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If lblOk.Text = "" Then
            MessageBox.Show("Harap Bayar Terlebih Dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            For i As Integer = 0 To dgv.RowCount - 1
                Dim transactionDate As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
                Call koneksi()
                Dim simpan As String = "INSERT INTO TblTransaksi VALUES ('" & dgv.Rows(i).Cells("notr").Value & "', '" & transactionDate & "', '" & lblTotal.Text & "', '" & dgv.Rows(i).Cells("idus").Value & "', '" & dgv.Rows(i).Cells("idbar").Value & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()

                Call koneksi()
                cmd = New SqlCommand("SELECT * FROM TblBarang", conn)
                rd = cmd.ExecuteReader
                rd.Read()

                Call koneksi()
                Dim reduceStock As String = "UPDATE TblBarang SET Qty = '" & rd!Qty - dgv.Rows(i).Cells("qty").Value & "' WHERE IdBarang = '" & dgv.Rows(i).Cells("idbar").Value & "'"
                cmd = New SqlCommand(reduceStock, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Simpan Data Transaksi Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kondisiAwal()
            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim quest As String = MessageBox.Show("Yakin Ingin Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quest = vbYes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub
End Class