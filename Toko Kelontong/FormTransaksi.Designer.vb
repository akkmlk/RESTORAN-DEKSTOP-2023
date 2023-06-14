<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBayarPrint = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kasirName = New System.Windows.Forms.Label()
        Me.Keranjang = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.lblOk = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblTotalQty = New System.Windows.Forms.Label()
        Me.txtNoTr = New System.Windows.Forms.TextBox()
        Me.txtIdBrg = New System.Windows.Forms.TextBox()
        Me.txtKdBrg = New System.Windows.Forms.TextBox()
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(245, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox1.TabIndex = 42
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(579, 137)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(208, 20)
        Me.txtTotal.TabIndex = 39
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(263, 368)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(204, 20)
        Me.txtBayar.TabIndex = 38
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(579, 82)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(208, 20)
        Me.txtQty.TabIndex = 41
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(245, 137)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(204, 20)
        Me.txtPrice.TabIndex = 36
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(246, 215)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(546, 115)
        Me.dgv.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(259, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Total Harga :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 465)
        Me.Panel1.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(32, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 125)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(32, 353)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 44)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kasir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(579, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Total Harga"
        '
        'btnBayarPrint
        '
        Me.btnBayarPrint.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBayarPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayarPrint.Location = New System.Drawing.Point(263, 394)
        Me.btnBayarPrint.Name = "btnBayarPrint"
        Me.btnBayarPrint.Size = New System.Drawing.Size(204, 34)
        Me.btnBayarPrint.TabIndex = 31
        Me.btnBayarPrint.Text = "Bayar / Print"
        Me.btnBayarPrint.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(698, 175)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 34)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Reset"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(603, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(579, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Quantitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Harga Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Pilih Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Form Transaksi"
        '
        'kasirName
        '
        Me.kasirName.AutoSize = True
        Me.kasirName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kasirName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kasirName.Location = New System.Drawing.Point(579, 14)
        Me.kasirName.Name = "kasirName"
        Me.kasirName.Size = New System.Drawing.Size(59, 20)
        Me.kasirName.TabIndex = 25
        Me.kasirName.Text = "Alamat"
        '
        'Keranjang
        '
        Me.Keranjang.AutoSize = True
        Me.Keranjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keranjang.Location = New System.Drawing.Point(241, 184)
        Me.Keranjang.Name = "Keranjang"
        Me.Keranjang.Size = New System.Drawing.Size(119, 25)
        Me.Keranjang.TabIndex = 23
        Me.Keranjang.Text = "Keranjang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(393, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Rp."
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(433, 345)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 20)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "Rp."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(259, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Kembalian :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(393, 431)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Rp."
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(433, 431)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(34, 20)
        Me.lblKembalian.TabIndex = 30
        Me.lblKembalian.Text = "Rp."
        '
        'lblOk
        '
        Me.lblOk.AutoSize = True
        Me.lblOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOk.Location = New System.Drawing.Point(682, 355)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(34, 20)
        Me.lblOk.TabIndex = 30
        Me.lblOk.Text = "Rp."
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(656, 394)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 34)
        Me.btnSimpan.TabIndex = 33
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'lblTotalQty
        '
        Me.lblTotalQty.AutoSize = True
        Me.lblTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.Location = New System.Drawing.Point(473, 366)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(34, 20)
        Me.lblTotalQty.TabIndex = 30
        Me.lblTotalQty.Text = "Rp."
        '
        'txtNoTr
        '
        Me.txtNoTr.Location = New System.Drawing.Point(241, 37)
        Me.txtNoTr.Name = "txtNoTr"
        Me.txtNoTr.Size = New System.Drawing.Size(123, 20)
        Me.txtNoTr.TabIndex = 36
        '
        'txtIdBrg
        '
        Me.txtIdBrg.Location = New System.Drawing.Point(370, 37)
        Me.txtIdBrg.Name = "txtIdBrg"
        Me.txtIdBrg.Size = New System.Drawing.Size(32, 20)
        Me.txtIdBrg.TabIndex = 36
        '
        'txtKdBrg
        '
        Me.txtKdBrg.Location = New System.Drawing.Point(408, 37)
        Me.txtKdBrg.Name = "txtKdBrg"
        Me.txtKdBrg.Size = New System.Drawing.Size(59, 20)
        Me.txtKdBrg.TabIndex = 36
        '
        'txtIdUser
        '
        Me.txtIdUser.Location = New System.Drawing.Point(541, 12)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(32, 20)
        Me.txtIdUser.TabIndex = 36
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(366, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 43
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtKdBrg)
        Me.Controls.Add(Me.txtIdUser)
        Me.Controls.Add(Me.txtIdBrg)
        Me.Controls.Add(Me.txtNoTr)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.lblOk)
        Me.Controls.Add(Me.lblTotalQty)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBayarPrint)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kasirName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Keranjang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBayarPrint As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents kasirName As Label
    Friend WithEvents Keranjang As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents lblOk As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblTotalQty As Label
    Friend WithEvents txtNoTr As TextBox
    Friend WithEvents txtIdBrg As TextBox
    Friend WithEvents txtKdBrg As TextBox
    Friend WithEvents txtIdUser As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
