<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.txtLayanan = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtLayanan
        '
        Me.txtLayanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLayanan.Location = New System.Drawing.Point(78, 248)
        Me.txtLayanan.Name = "txtLayanan"
        Me.txtLayanan.Size = New System.Drawing.Size(840, 15)
        Me.txtLayanan.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(78, 322)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(840, 15)
        Me.TextBox1.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(78, 397)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(396, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(532, 397)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(396, 22)
        Me.DateTimePicker2.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(60, 574)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(880, 48)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Kembali"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(508, 520)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(432, 48)
        Me.btnHapus.TabIndex = 17
        Me.btnHapus.Text = "Batal"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUbah.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(60, 520)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(432, 48)
        Me.btnUbah.TabIndex = 16
        Me.btnUbah.Text = "Tambah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(78, 475)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(850, 24)
        Me.ComboBox1.TabIndex = 28
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtLayanan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLayanan As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
