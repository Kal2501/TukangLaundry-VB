<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahLayanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahLayanan))
        Me.txtLayanan = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLayanan
        '
        Me.txtLayanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLayanan.Location = New System.Drawing.Point(81, 309)
        Me.txtLayanan.Name = "txtLayanan"
        Me.txtLayanan.Size = New System.Drawing.Size(840, 15)
        Me.txtLayanan.TabIndex = 3
        '
        'txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Location = New System.Drawing.Point(81, 383)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(840, 15)
        Me.txtHarga.TabIndex = 4
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnKembali.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(61, 472)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(880, 48)
        Me.btnKembali.TabIndex = 9
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(509, 418)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(432, 48)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(61, 418)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(432, 48)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'TambahLayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtLayanan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahLayanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLayanan As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
End Class
