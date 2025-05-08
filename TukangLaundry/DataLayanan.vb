Imports MySql.Data.MySqlClient

Public Class DataLayanan

    Sub TampilData()
        DA = New MySqlDataAdapter("SELECT * FROM paket", CONN)
        DS = New DataSet()
        DA.Fill(DS, "paket")
        DataGridView1.DataSource = DS.Tables("paket")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM paket WHERE nama LIKE '%" & txtSearch.Text & "%'", CONN)
        DS = New DataSet()
        DA.Fill(DS, "paket")
        DataGridView1.DataSource = DS.Tables("paket")
    End Sub

    Sub AturTampilanGrid()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersDefaultCellStyle.Font = New Font("Plus Jakarta Sans", 11, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Plus Jakarta Sans", 10)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255) ' biru muda lembut
            .AlternatingRowsDefaultCellStyle.Font = New Font("Plus Jakarta Sans", 10)

            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219) ' biru modern
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .EnableHeadersVisualStyles = False

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .GridColor = Color.LightGray
        End With
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            DetailLayanan.Show()
            DetailLayanan.idEdit = row.Cells(0).Value
            DetailLayanan.txtHarga.Text = row.Cells(1).Value.ToString()
            DetailLayanan.txtLayanan.Text = row.Cells(2).Value.ToString()
            DetailLayanan.statusEdit = True
            Me.Close()
        End If
    End Sub


    Private Sub dataLayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilData()
        AturTampilanGrid()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahLayanan.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub btnCetakData_Click(sender As Object, e As EventArgs) Handles btnCetakData.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim judulFont As New Font("Arial", 14, FontStyle.Bold)
        Dim isiFont As New Font("Arial", 10)
        Dim tinggiBaris As Integer = 25
        Dim lebarKolomNama As Integer = 250
        Dim lebarKolomHarga As Integer = 120
        Dim totalLebarTabel As Integer = lebarKolomNama + lebarKolomHarga

        ' Posisi awal Y (vertikal)
        Dim y As Integer = e.MarginBounds.Top

        ' Judul
        Dim judul As String = "LAPORAN DATA LAYANAN TERBARU"
        Dim judulLebar As SizeF = e.Graphics.MeasureString(judul, judulFont)
        e.Graphics.DrawString(judul, judulFont, Brushes.Black,
                              e.MarginBounds.Left + (e.MarginBounds.Width - judulLebar.Width) / 2, y)
        y += 50

        ' Posisi X tengah halaman
        Dim startX As Integer = e.MarginBounds.Left + (e.MarginBounds.Width - totalLebarTabel) / 2

        ' Header
        e.Graphics.DrawRectangle(Pens.Black, startX, y, lebarKolomNama, tinggiBaris)
        e.Graphics.DrawRectangle(Pens.Black, startX + lebarKolomNama, y, lebarKolomHarga, tinggiBaris)
        e.Graphics.DrawString("Nama Paket Layanan", isiFont, Brushes.Black, startX + 5, y + 5)
        e.Graphics.DrawString("Harga", isiFont, Brushes.Black, startX + lebarKolomNama + 5, y + 5)
        y += tinggiBaris

        ' Data
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim nama As String = row.Cells("nama").Value.ToString()
                Dim harga As String = "Rp " & FormatNumber(row.Cells("harga_per_kg").Value, 0)

                ' Kotak
                e.Graphics.DrawRectangle(Pens.Black, startX, y, lebarKolomNama, tinggiBaris)
                e.Graphics.DrawRectangle(Pens.Black, startX + lebarKolomNama, y, lebarKolomHarga, tinggiBaris)

                ' Teks
                e.Graphics.DrawString(nama, isiFont, Brushes.Black, startX + 5, y + 5)
                e.Graphics.DrawString(harga, isiFont, Brushes.Black, startX + lebarKolomNama + 5, y + 5)
                y += tinggiBaris
            End If
        Next
    End Sub

End Class