Imports MySql.Data.MySqlClient

Public Class DataPelanggan
    Dim currentRowIndex As Integer = 0
    Dim reportType As String = "SELESAI"

    Sub TampilData()
        DA = New MySqlDataAdapter("SELECT p.pesanan_id, p.nama_pelanggan, p.berat_kg, p.tanggal_pesanan, p.tanggal_selesai,  IF(p.status = 1, 'Selesai', 'Proses') AS status,  l.nama, (p.berat_kg * l.harga_per_kg) AS total_harga  FROM pesanan p JOIN paket l ON p.layanan_id = l.paket_id", CONN)
        DS = New DataSet()
        DA.Fill(DS, "pesanan")
        DataGridView1.DataSource = DS.Tables("pesanan")
    End Sub

    Sub AturTampilanGrid()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ColumnHeadersDefaultCellStyle.Font = New Font("Plus Jakarta Sans", 11, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Plus Jakarta Sans", 10)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black

            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255)
            .AlternatingRowsDefaultCellStyle.Font = New Font("Plus Jakarta Sans", 10)

            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .EnableHeadersVisualStyles = False

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .GridColor = Color.LightGray

            .ScrollBars = ScrollBars.Horizontal
        End With

        DataGridView1.Columns(0).Width = 70 ' id_pesanan
        DataGridView1.Columns(1).Width = 120 ' nama_pelanggan
        DataGridView1.Columns(2).Width = 90 ' berat_kg
        DataGridView1.Columns(3).Width = 100 ' tanggal_masuk
        DataGridView1.Columns(4).Width = 100 ' tanggal_keluar
        DataGridView1.Columns(5).Width = 90 ' status
        DataGridView1.Columns(6).Width = 140 ' nama_layanan
        DataGridView1.Columns(7).Width = 120 ' total_harga
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            DetailPelanggan.Show()
            DetailPelanggan.idEdit = row.Cells(0).Value
            DetailPelanggan.txtNama.Text = row.Cells(1).Value.ToString()
            DetailPelanggan.txtBerat.Text = row.Cells(2).Value.ToString()
            DetailPelanggan.dtpPesanan.Value = Date.Parse(row.Cells(3).Value)
            DetailPelanggan.dtpSelesai.Value = Date.Parse(row.Cells(4).Value)
            DetailPelanggan.cmbStatus.Text = If(row.Cells(5).Value.ToString() = "Selesai", "Selesai", "Proses")
            DetailPelanggan.cmbLayanan.Text = DetailPelanggan.cmbLayanan.Items.Cast(Of String)().FirstOrDefault(Function(x) x.Contains(row.Cells(6).Value.ToString()))
            DetailPelanggan.statusEdit = True
            Me.Close()
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        koneksi()
        DA = New MySqlDataAdapter("SELECT p.pesanan_id, p.nama_pelanggan, p.berat_kg, p.tanggal_pesanan, p.tanggal_selesai,  IF(p.status = 1, 'Selesai', 'Belum') AS status, l.nama, (p.berat_kg * l.harga_per_kg) AS total_harga  FROM pesanan p JOIN paket l ON p.layanan_id = l.paket_id WHERE p.nama_pelanggan LIKE '%" & txtSearch.Text & "%'", CONN)
        DS = New DataSet()
        DA.Fill(DS, "pesanan")
        DataGridView1.DataSource = DS.Tables("pesanan")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahPelanggan.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub DataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilData()
        AturTampilanGrid()
    End Sub

    Private Sub btnCetakData_Click(sender As Object, e As EventArgs) Handles btnCetakData.Click
        currentRowIndex = 0
        reportType = "SELESAI"
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim judulFont As New Font("Arial", 14, FontStyle.Bold)
        Dim isiFont As New Font("Arial", 10)
        Dim tinggiBaris As Integer = 25
        Dim lebarKolomNama As Integer = 250
        Dim lebarKolomStatus As Integer = 150
        Dim lebarKolomTanggal As Integer = 150
        Dim totalLebarTabel As Integer = lebarKolomNama + lebarKolomStatus + lebarKolomTanggal

        '-- gambar judul
        Dim y As Integer = e.MarginBounds.Top
        Dim judul As String = If(reportType = "SELESAI",
                                 "LAPORAN PELANGGAN SELESAI",
                                 "LAPORAN PELANGGAN PROSES")
        Dim judulLebar As SizeF = e.Graphics.MeasureString(judul, judulFont)
        e.Graphics.DrawString(judul, judulFont, Brushes.Black,
            e.MarginBounds.Left + (e.MarginBounds.Width - judulLebar.Width) / 2, y)
        y += 50

        '-- header tabel
        Dim startX As Integer = e.MarginBounds.Left + (e.MarginBounds.Width - totalLebarTabel) / 2
        e.Graphics.DrawRectangle(Pens.Black, startX, y, lebarKolomNama, tinggiBaris)
        e.Graphics.DrawRectangle(Pens.Black, startX + lebarKolomNama, y, lebarKolomStatus, tinggiBaris)
        e.Graphics.DrawRectangle(Pens.Black, startX + lebarKolomNama + lebarKolomStatus, y, lebarKolomTanggal, tinggiBaris)
        e.Graphics.DrawString("Nama Pelanggan", isiFont, Brushes.Black, startX + 5, y + 5)
        e.Graphics.DrawString("Status", isiFont, Brushes.Black, startX + lebarKolomNama + 5, y + 5)
        e.Graphics.DrawString("Tanggal", isiFont, Brushes.Black, startX + lebarKolomNama + lebarKolomStatus + 5, y + 5)
        y += tinggiBaris

        '-- loop data utk jenis laporan saat ini
        Dim filterLower = reportType.ToLower()  ' "selesai" atau "proses"
        While currentRowIndex < DataGridView1.Rows.Count
            Dim row = DataGridView1.Rows(currentRowIndex)
            If Not row.IsNewRow AndAlso row.Cells("status").Value.ToString().ToLower() = filterLower Then
                Dim nama = row.Cells("nama_pelanggan").Value.ToString()
                Dim status = row.Cells("status").Value.ToString()
                Dim tanggal As String
                If reportType = "SELESAI" Then
                    tanggal = CDate(row.Cells("tanggal_selesai").Value).ToString("dd/MM/yyyy")
                Else
                    tanggal = CDate(row.Cells("tanggal_pesanan").Value).ToString("dd/MM/yyyy")
                End If

                '-- cek page break
                If y + tinggiBaris > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Return
                End If

                '-- gambar kotak & isi teks
                e.Graphics.DrawRectangle(Pens.Black, startX, y, lebarKolomNama, tinggiBaris)
                e.Graphics.DrawRectangle(Pens.Black, startX + lebarKolomNama, y, lebarKolomStatus, tinggiBaris)
                e.Graphics.DrawRectangle(Pens.Black, startX + lebarKolomNama + lebarKolomStatus, y, lebarKolomTanggal, tinggiBaris)
                e.Graphics.DrawString(nama, isiFont, Brushes.Black, startX + 5, y + 5)
                e.Graphics.DrawString(status, isiFont, Brushes.Black, startX + lebarKolomNama + 5, y + 5)
                e.Graphics.DrawString(tanggal, isiFont, Brushes.Black, startX + lebarKolomNama + lebarKolomStatus + 5, y + 5)
                y += tinggiBaris
            End If
            currentRowIndex += 1
        End While

        '-- jika baru selesai cetak "SELESAI", lanjut ke "PROSES"
        If reportType = "SELESAI" Then
            reportType = "PROSES"
            currentRowIndex = 0
            e.HasMorePages = True    ' generate page berikutnya
        Else
            e.HasMorePages = False   ' selesai kedua laporan
        End If
    End Sub

End Class