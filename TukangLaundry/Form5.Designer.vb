<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.dtpTanggalPesanan = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalSelesai = New System.Windows.Forms.DateTimePicker()
        Me.cmbLayanan = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(83, 226)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(840, 15)
        Me.txtNamaPelanggan.TabIndex = 3
        '
        'txtBerat
        '
        Me.txtBerat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBerat.Location = New System.Drawing.Point(83, 302)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(840, 15)
        Me.txtBerat.TabIndex = 4
        '
        'dtpTanggalPesanan
        '
        Me.dtpTanggalPesanan.CalendarForeColor = System.Drawing.SystemColors.Window
        Me.dtpTanggalPesanan.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtpTanggalPesanan.Location = New System.Drawing.Point(83, 376)
        Me.dtpTanggalPesanan.Name = "dtpTanggalPesanan"
        Me.dtpTanggalPesanan.Size = New System.Drawing.Size(392, 22)
        Me.dtpTanggalPesanan.TabIndex = 5
        '
        'dtpTanggalSelesai
        '
        Me.dtpTanggalSelesai.CalendarForeColor = System.Drawing.SystemColors.Window
        Me.dtpTanggalSelesai.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtpTanggalSelesai.Location = New System.Drawing.Point(531, 376)
        Me.dtpTanggalSelesai.Name = "dtpTanggalSelesai"
        Me.dtpTanggalSelesai.Size = New System.Drawing.Size(392, 22)
        Me.dtpTanggalSelesai.TabIndex = 6
        '
        'cmbLayanan
        '
        Me.cmbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLayanan.FormattingEnabled = True
        Me.cmbLayanan.Location = New System.Drawing.Point(83, 449)
        Me.cmbLayanan.Name = "cmbLayanan"
        Me.cmbLayanan.Size = New System.Drawing.Size(392, 24)
        Me.cmbLayanan.TabIndex = 7
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(531, 449)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(392, 24)
        Me.cmbStatus.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(63, 575)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(880, 48)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Data Layanan"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(511, 504)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(432, 48)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(63, 504)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(432, 48)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbLayanan)
        Me.Controls.Add(Me.dtpTanggalSelesai)
        Me.Controls.Add(Me.dtpTanggalPesanan)
        Me.Controls.Add(Me.txtBerat)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggalPesanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbLayanan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
