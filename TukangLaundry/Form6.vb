Imports MySql.Data.MySqlClient

Public Class Form6

    Dim statusEdit As Boolean = False
    Dim idEdit As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Sub TampilLayanan()
        cmbLayanan.Items.Clear()
        CMD = New MySqlCommand("SELECT * FROM paket", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            cmbLayanan.Items.Add(RD("paket_id") & " - " & RD("nama") & " (@Rp" & RD("harga_per_kg") & ")")
        End While
        RD.Close()
    End Sub

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

            .ScrollBars = ScrollBars.Both
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilLayanan()
        TampilData()
        cmbStatus.Items.Add("Proses")
        cmbStatus.Items.Add("Selesai")
        cmbStatus.SelectedIndex = 0
        AturTampilanGrid()
    End Sub

    Sub Kosong()
        txtNamaPelanggan.Clear()
        txtBerat.Clear()
        cmbStatus.SelectedIndex = 0
        cmbLayanan.SelectedIndex = -1
        dtpTanggalPesan.Value = Now
        dtpTanggalSelesai.Value = Now
        statusEdit = False
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs)
        If Not statusEdit Then Exit Sub
        koneksi()
        Dim idLayanan As Integer = Val(Split(cmbLayanan.Text, " - ")(0))
        Dim Status As Boolean
        If txtNamaPelanggan.Text = "" Or txtBerat.Text = "" Or cmbLayanan.SelectedIndex = -1 Then
            MessageBox.Show("Isi semua data.")
            Exit Sub
        End If

        If dtpTanggalPesan.Value.ToString("yyyy-MM-dd") > dtpTanggalSelesai.Value.ToString("yyyy-MM-dd") Then
            MessageBox.Show("Tanggal Pesanan tidak boleh melewati tanggal selesai!")
            Exit Sub
        End If


        If cmbStatus.Text() = "Selesai" Then
            Status = 1
        Else
            Status = 0
        End If

        STR = "UPDATE pesanan SET nama_pelanggan=@nama, berat_kg=@berat, tanggal_pesanan=@tgl1, tanggal_selesai=@tgl2, status=@status, layanan_id=@layanan WHERE pesanan_id=@id"
        CMD = New MySqlCommand(STR, CONN)
        CMD.Parameters.AddWithValue("@nama", txtNamaPelanggan.Text)
        CMD.Parameters.AddWithValue("@berat", Val(txtBerat.Text))
        CMD.Parameters.AddWithValue("@tgl1", dtpTanggalPesan.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@tgl2", dtpTanggalSelesai.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@status", Status)
        CMD.Parameters.AddWithValue("@layanan", idLayanan)
        CMD.Parameters.AddWithValue("@id", idEdit)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil diubah!!")
        TampilData()
        Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)
        If Not statusEdit Then Exit Sub
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM pesanan WHERE pesanan_id=@id", CONN)
            CMD.Parameters.AddWithValue("@id", idEdit)
            CMD.ExecuteNonQuery()
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            idEdit = row.Cells(0).Value
            txtNamaPelanggan.Text = row.Cells(1).Value.ToString()
            txtBerat.Text = row.Cells(2).Value.ToString()
            dtpTanggalPesan.Value = Date.Parse(row.Cells(3).Value)
            dtpTanggalSelesai.Value = Date.Parse(row.Cells(4).Value)
            cmbStatus.Text = If(row.Cells(5).Value.ToString() = "Selesai", "Selesai", "Proses")
            cmbLayanan.Text = cmbLayanan.Items.Cast(Of String)().FirstOrDefault(Function(x) x.Contains(row.Cells(6).Value.ToString()))
            statusEdit = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        koneksi()
        DA = New MySqlDataAdapter("SELECT p.pesanan_id, p.nama_pelanggan, p.berat_kg, p.tanggal_pesanan, p.tanggal_selesai,  IF(p.status = 1, 'Selesai', 'Belum') AS status, l.nama, (p.berat_kg * l.harga_per_kg) AS total_harga  FROM pesanan p JOIN paket l ON p.layanan_id = l.paket_id WHERE p.nama_pelanggan LIKE '%" & txtSearch.Text & "%'", CONN)
        DS = New DataSet()
        DA.Fill(DS, "pesanan")
        DataGridView1.DataSource = DS.Tables("pesanan")
    End Sub


End Class