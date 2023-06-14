Imports System.Data.SqlClient
Public Class FormBarang
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        txtIdBrg.Text = ""
        txtKdBrg.Text = ""
        txtName.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtSearch.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Botol")
        ComboBox1.Items.Add("Porsi")
        ComboBox1.Items.Add("Pack")
        ComboBox1.Items.Add("Dus")
        txtKdBrg.Enabled = False
        txtIdBrg.Visible = False
        Call munculGrid()
        Call incrementKdBrg()
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("SELECT * FROM TblBarang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblBarang")
        dgv.DataSource = ds.Tables("tblBarang")
        dgv.ReadOnly = True
    End Sub

    Sub incrementKdBrg()
        Dim code As String
        Call koneksi()
        cmd = New SqlCommand("SELECT KodeBarang FROM TblBarang ORDER BY KodeBarang DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            code = Microsoft.VisualBasic.Mid(rd!KodeBarang, 4, 3) + 1
            If Len(code) = 1 Then
                code = "BRG" & "00" & code
            ElseIf Len(code) = 2 Then
                code = "BRG" & "0" & code
            ElseIf Len(code) = 3 Then
                code = "BRG" & code
            End If
        Else
            code = "BRG001"
        End If
        txtKdBrg.Text = code
    End Sub

    Public Sub numberOnly(ByVal e As Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Field Khusus Mengisi Numeric", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        Call numberOnly(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtName.Text = "" Or ComboBox1.Text = "" Or txtKdBrg.Text = "" Or txtQty.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Semua Field Sangat Dibutuhkan, Tolong Dilengkapi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim expiredDate As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
            Call koneksi()
            Dim insert As String = "INSERT INTO TblBarang VALUES ('" & txtKdBrg.Text & "', '" & txtName.Text & "', '" & expiredDate & "', '" & txtQty.Text & "', '" & ComboBox1.Text & "', '" & txtPrice.Text & "')"
            cmd = New SqlCommand(insert, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Tambah Data Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call kondisiAwal()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtIdBrg.Text = "" Then
            MessageBox.Show("Pilih Data Yang Ingin di Update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtName.Text = "" Or ComboBox1.Text = "" Or txtKdBrg.Text = "" Or txtQty.Text = "" Or txtPrice.Text = "" Then
                MessageBox.Show("Semua Field Sangat Dibutuhkan, Tolong Dilengkapi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim expiredDate As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
                Call koneksi()
                Dim update As String = "UPDATE TblBarang SET KodeBarang = '" & txtKdBrg.Text & "', NamaBarang = '" & txtName.Text & "', ExpiredDate = '" & expiredDate & "', Qty = '" & txtQty.Text & "', Satuan = '" & ComboBox1.Text & "', HargaSatuan = '" & txtPrice.Text & "' WHERE IdBarang = '" & txtIdBrg.Text & "'"
                cmd = New SqlCommand(update, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Update Data Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtIdBrg.Text = "" Then
            MessageBox.Show("Pilih Data Yang Ingin di Hapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim quest As String = MessageBox.Show("Yakin Ingin Menghapusnya?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If quest = vbYes Then
                Call koneksi()
                cmd = New SqlCommand("DELETE TblBarang WHERE IdBarang = '" & txtIdBrg.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Data Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TblBarang WHERE NamaBarang LIKE '%" & txtSearch.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            da = New SqlDataAdapter("SELECT * FROM TblBarang WHERE NamaBarang LIKE '%" & txtSearch.Text & "%'", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "search")
            dgv.DataSource = ds.Tables("Search")
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = dgv.CurrentRow.Index

        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TblBarang WHERE IdBarang = '" & dgv.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader

        rd.Read()
        If rd.HasRows Then
            txtIdBrg.Text = rd!IdBarang
            txtKdBrg.Text = rd!KodeBarang
            txtName.Text = rd!NamaBarang
            DateTimePicker1.Value = rd!ExpiredDate
            txtPrice.Text = rd!HargaSatuan
            txtQty.Text = rd!Qty
            ComboBox1.Text = rd!Satuan
            On Error Resume Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim quest As String = MessageBox.Show("Yakin Ingin Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quest = vbYes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Call numberOnly(e)
    End Sub
End Class