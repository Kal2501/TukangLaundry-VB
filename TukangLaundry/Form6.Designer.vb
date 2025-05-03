<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbLayanan = New System.Windows.Forms.ComboBox()
        Me.dtpTanggalSelesai = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalPesan = New System.Windows.Forms.DateTimePicker()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Location = New System.Drawing.Point(104, 126)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(816, 15)
        Me.txtSearch.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(840, 108)
        Me.DataGridView1.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(60, 643)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(880, 41)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Kembali ke Menu"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(508, 598)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(432, 39)
        Me.btnHapus.TabIndex = 19
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUbah.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(60, 598)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(432, 39)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(528, 554)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(392, 24)
        Me.cmbStatus.TabIndex = 17
        '
        'cmbLayanan
        '
        Me.cmbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLayanan.FormattingEnabled = True
        Me.cmbLayanan.Location = New System.Drawing.Point(80, 554)
        Me.cmbLayanan.Name = "cmbLayanan"
        Me.cmbLayanan.Size = New System.Drawing.Size(392, 24)
        Me.cmbLayanan.TabIndex = 16
        '
        'dtpTanggalSelesai
        '
        Me.dtpTanggalSelesai.CalendarForeColor = System.Drawing.SystemColors.Window
        Me.dtpTanggalSelesai.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtpTanggalSelesai.Location = New System.Drawing.Point(528, 482)
        Me.dtpTanggalSelesai.Name = "dtpTanggalSelesai"
        Me.dtpTanggalSelesai.Size = New System.Drawing.Size(392, 22)
        Me.dtpTanggalSelesai.TabIndex = 15
        '
        'dtpTanggalPesan
        '
        Me.dtpTanggalPesan.CalendarForeColor = System.Drawing.SystemColors.Window
        Me.dtpTanggalPesan.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtpTanggalPesan.Location = New System.Drawing.Point(80, 482)
        Me.dtpTanggalPesan.Name = "dtpTanggalPesan"
        Me.dtpTanggalPesan.Size = New System.Drawing.Size(392, 22)
        Me.dtpTanggalPesan.TabIndex = 14
        '
        'txtBerat
        '
        Me.txtBerat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBerat.Location = New System.Drawing.Point(80, 413)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(840, 15)
        Me.txtBerat.TabIndex = 13
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(80, 337)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(840, 15)
        Me.txtNamaPelanggan.TabIndex = 12
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbLayanan)
        Me.Controls.Add(Me.dtpTanggalSelesai)
        Me.Controls.Add(Me.dtpTanggalPesan)
        Me.Controls.Add(Me.txtBerat)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLayanan As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTanggalSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalPesan As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
End Class
