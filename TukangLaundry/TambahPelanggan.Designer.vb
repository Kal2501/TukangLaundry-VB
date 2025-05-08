<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahPelanggan))
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.dtpPesanan = New System.Windows.Forms.DateTimePicker()
        Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cmbLayanan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Location = New System.Drawing.Point(78, 248)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(840, 15)
        Me.txtNama.TabIndex = 11
        '
        'txtBerat
        '
        Me.txtBerat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBerat.Location = New System.Drawing.Point(78, 322)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(840, 15)
        Me.txtBerat.TabIndex = 12
        '
        'dtpPesanan
        '
        Me.dtpPesanan.Location = New System.Drawing.Point(78, 397)
        Me.dtpPesanan.Name = "dtpPesanan"
        Me.dtpPesanan.Size = New System.Drawing.Size(396, 22)
        Me.dtpPesanan.TabIndex = 14
        '
        'dtpSelesai
        '
        Me.dtpSelesai.Location = New System.Drawing.Point(532, 397)
        Me.dtpSelesai.Name = "dtpSelesai"
        Me.dtpSelesai.Size = New System.Drawing.Size(396, 22)
        Me.dtpSelesai.TabIndex = 15
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnKembali.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(60, 574)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(880, 48)
        Me.btnKembali.TabIndex = 18
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(508, 520)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(432, 48)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(60, 520)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(432, 48)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'cmbLayanan
        '
        Me.cmbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLayanan.FormattingEnabled = True
        Me.cmbLayanan.Location = New System.Drawing.Point(78, 475)
        Me.cmbLayanan.Name = "cmbLayanan"
        Me.cmbLayanan.Size = New System.Drawing.Size(850, 24)
        Me.cmbLayanan.TabIndex = 28
        '
        'TambahPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.cmbLayanan)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dtpSelesai)
        Me.Controls.Add(Me.dtpPesanan)
        Me.Controls.Add(Me.txtBerat)
        Me.Controls.Add(Me.txtNama)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents dtpPesanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents cmbLayanan As System.Windows.Forms.ComboBox
End Class
