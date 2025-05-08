<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailPelanggan))
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.dtpPesanan = New System.Windows.Forms.DateTimePicker()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbLayanan = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnKembali.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(61, 570)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(880, 48)
        Me.btnKembali.TabIndex = 26
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(509, 516)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(432, 48)
        Me.btnHapus.TabIndex = 25
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUbah.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(61, 516)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(432, 48)
        Me.btnUbah.TabIndex = 24
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'dtpSelesai
        '
        Me.dtpSelesai.Location = New System.Drawing.Point(533, 393)
        Me.dtpSelesai.Name = "dtpSelesai"
        Me.dtpSelesai.Size = New System.Drawing.Size(396, 22)
        Me.dtpSelesai.TabIndex = 23
        '
        'dtpPesanan
        '
        Me.dtpPesanan.Location = New System.Drawing.Point(79, 393)
        Me.dtpPesanan.Name = "dtpPesanan"
        Me.dtpPesanan.Size = New System.Drawing.Size(396, 22)
        Me.dtpPesanan.TabIndex = 22
        '
        'txtBerat
        '
        Me.txtBerat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBerat.Location = New System.Drawing.Point(79, 318)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(840, 15)
        Me.txtBerat.TabIndex = 20
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(79, 244)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(840, 15)
        Me.txtNama.TabIndex = 19
        '
        'cmbLayanan
        '
        Me.cmbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLayanan.FormattingEnabled = True
        Me.cmbLayanan.Location = New System.Drawing.Point(79, 465)
        Me.cmbLayanan.Name = "cmbLayanan"
        Me.cmbLayanan.Size = New System.Drawing.Size(396, 24)
        Me.cmbLayanan.TabIndex = 27
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(533, 465)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(396, 24)
        Me.cmbStatus.TabIndex = 28
        '
        'DetailPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbLayanan)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.dtpSelesai)
        Me.Controls.Add(Me.dtpPesanan)
        Me.Controls.Add(Me.txtBerat)
        Me.Controls.Add(Me.txtNama)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DetailPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents dtpSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPesanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbLayanan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
End Class
