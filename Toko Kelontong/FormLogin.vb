Imports System.Data.SqlClient
Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
        DateTimePicker1.Visible = False
    End Sub

    Sub insertLog()
        Dim dateLog As String = Format(DateTimePicker1.Value, "yyyy/MM/dd hh:MM:ss")
        Call koneksi()
        cmd = New SqlCommand("INSERT INTO TblLog VALUES ('" & dateLog & "', '" & Button1.Text & "', '" & rd!IdUser & "')", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Username Dan Password Tidak Boleh Kosong")
        Else
            Call koneksi()
            cmd = New SqlCommand("SELECT * FROM TblUser WHERE Username = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                FormTransaksi.kasirName.Text = rd!Nama
                FormTransaksi.txtIdUser.Text = rd!IdUser
                If TextBox2.Text = rd!Password.ToString.Trim Then
                    If rd!TipeUser.ToString = "Admin" Then
                        Call insertLog()
                        Me.Hide()
                        FormAdmin.Show()
                    ElseIf rd!TipeUser.ToString = "Gudang" Then
                        Call insertLog()
                        Me.Hide()
                        FormBarang.Show()
                    ElseIf rd!TipeUser.ToString = "Kasir" Then
                        Call insertLog()
                        Me.Hide()
                        FormTransaksi.Show()
                    End If
                Else
                    MessageBox.Show("Password Salah")
                End If
            Else
                MessageBox.Show("Username Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call kondisiAwal()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
