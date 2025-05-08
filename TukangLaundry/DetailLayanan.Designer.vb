<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailLayanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailLayanan))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtLayanan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(61, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(880, 48)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Kembali"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(509, 418)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(432, 48)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUbah.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(61, 418)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(432, 48)
        Me.btnUbah.TabIndex = 12
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Location = New System.Drawing.Point(81, 383)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(840, 15)
        Me.txtHarga.TabIndex = 11
        '
        'txtLayanan
        '
        Me.txtLayanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLayanan.Location = New System.Drawing.Point(81, 309)
        Me.txtLayanan.Name = "txtLayanan"
        Me.txtLayanan.Size = New System.Drawing.Size(840, 15)
        Me.txtLayanan.TabIndex = 10
        '
        'DetailLayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtLayanan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DetailLayanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtLayanan As System.Windows.Forms.TextBox
End Class
