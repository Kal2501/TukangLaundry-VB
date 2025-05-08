Imports MySql.Data.MySqlClient

Public Class TambahPelanggan

    Sub Kosong()
        txtNama.Clear()
        txtBerat.Clear()
        cmbLayanan.SelectedIndex = -1
        dtpPesanan.Value = Now
        dtpSelesai.Value = Now
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

    Private Sub TambahPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilLayanan()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNama.Text = "" Or txtBerat.Text = "" Or cmbLayanan.SelectedIndex = -1 Then
            MessageBox.Show("Isi semua data.")
            Exit Sub
        End If

        If dtpSelesai.Value < dtpPesanan.Value Then
            MessageBox.Show("Tanggal selesai tidak boleh lebih awal dari tanggal pesanan!")
            Exit Sub
        End If

        koneksi()
        Dim idLayanan As Integer = Val(Split(cmbLayanan.Text, " - ")(0))
        STR = "INSERT INTO pesanan (nama_pelanggan, berat_kg, tanggal_pesanan, tanggal_selesai, status, layanan_id) VALUES (@nama, @berat, @tgl1, @tgl2, @status, @layanan)"
        CMD = New MySqlCommand(STR, CONN)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@berat", Val(txtBerat.Text))
        CMD.Parameters.AddWithValue("@tgl1", dtpPesanan.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@tgl2", dtpSelesai.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@status", "0")
        CMD.Parameters.AddWithValue("@layanan", idLayanan)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data pelanggan berhasil ditambahkan!")
        Kosong()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        DataPelanggan.Show()
        Me.Close()
    End Sub

    Private Sub txtBerat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBerat.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtBerat.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class