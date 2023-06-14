Imports System.Data.SqlClient
Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Gudang")
        ComboBox1.Items.Add("Kasir")
        txtName.Text = ""
        txtIdUser.Text = ""
        txtTelpon.Text = ""
        txtAlamat.Text = ""
        txtUsername.Text = ""
        txtPass.Text = ""
        txtSearch.Text = ""
        txtIdUser.Visible = False
        Button2.Enabled = False
        Call munculGrid()
    End Sub

    Sub munculGrid()
        Call koneksi()
        da = New SqlDataAdapter("SELECT * FROM TblUser", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblUser")
        dgv.DataSource = ds.Tables("tblUser")
        dgv.ReadOnly = True
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = dgv.CurrentRow.Index

        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TblUser WHERE IdUser = '" & dgv.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtIdUser.Text = rd!IdUser
            txtName.Text = rd!Nama
            ComboBox1.Text = rd!TipeUser
            txtTelpon.Text = rd!Telpon
            txtAlamat.Text = rd!Alamat
            txtUsername.Text = rd!Username
            txtPass.Text = rd!Password
            On Error Resume Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtName.Text = "" Or ComboBox1.Text = "" Or txtTelpon.Text = "" Or txtAlamat.Text = "" Or txtUsername.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Semua Field Sangat Dibutuhkan, Tolong Dilengkapi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            Dim insert As String = "INSERT INTO TblUser VALUES ('" & ComboBox1.Text & "', '" & txtName.Text & "', '" & txtAlamat.Text & "', '" & txtTelpon.Text & "', '" & txtUsername.Text & "', '" & txtPass.Text & "')"
            cmd = New SqlCommand(insert, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Tambah Data Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call kondisiAwal()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtIdUser.Text = "" Then
            MessageBox.Show("Pilih Data Yang Ingin di Update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtName.Text = "" Or ComboBox1.Text = "" Or txtTelpon.Text = "" Or txtAlamat.Text = "" Or txtUsername.Text = "" Or txtPass.Text = "" Then
                MessageBox.Show("Semua Field Sangat Dibutuhkan, Tolong Dilengkapi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Call koneksi()
                Dim update As String = "UPDATE TblUser SET TipeUser = '" & ComboBox1.Text & "', Nama = '" & txtName.Text & "', Alamat = '" & txtAlamat.Text & "', Telpon = '" & txtTelpon.Text & "', Username = '" & txtUsername.Text & "', Password = '" & txtPass.Text & "' WHERE IdUser = '" & txtIdUser.Text & "'"
                cmd = New SqlCommand(update, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Update Data Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtIdUser.Text = "" Then
            MessageBox.Show("Pilih Data Yang Ingin di Hapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim quest As String = MessageBox.Show("Yakin Ingin Menghapusnya?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If quest = vbYes Then
                Call koneksi()
                cmd = New SqlCommand("DELETE TblUser WHERE IdUser = '" & txtIdUser.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Delete Data Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TblUser WHERE Nama LIKE '%" & txtSearch.Text & "%' OR Username LIKE '%" & txtSearch.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call koneksi()
            da = New SqlDataAdapter("SELECT * FROM TblUser WHERE Nama LIKE '%" & txtSearch.Text & "%' OR Username LIKE '%" & txtSearch.Text & "%'", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "search")
            dgv.DataSource = ds.Tables("search")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FormLaporan.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim quest As String = MessageBox.Show("Yakin Ingin Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quest = vbYes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub txtTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpon.KeyPress
        Call FormBarang.numberOnly(e)
    End Sub
End Class