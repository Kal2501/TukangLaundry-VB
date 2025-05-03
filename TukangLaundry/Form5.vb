Imports MySql.Data.MySqlClient

Public Class Form5


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Close()
    End Sub

    Sub Kosong()
        txtNamaPelanggan.Clear()
        txtBerat.Clear()
        cmbStatus.SelectedIndex = 0
        cmbLayanan.SelectedIndex = -1
        dtpTanggalPesanan.Value = Now
        dtpTanggalSelesai.Value = Now
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

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaPelanggan.Text = "" Or txtBerat.Text = "" Or cmbLayanan.SelectedIndex = -1 Then
            MessageBox.Show("Isi semua data.")
            Exit Sub
        End If

        If dtpTanggalPesanan.Value.ToString("yyyy-MM-dd") > dtpTanggalSelesai.Value.ToString("yyyy-MM-dd") Then
            MessageBox.Show("Tanggal Pesanan tidak boleh melewati tanggal selesai!")
            Exit Sub
        End If

        koneksi()
        Dim idLayanan As Integer = Val(Split(cmbLayanan.Text, " - ")(0))
        Dim Status As Boolean

        If cmbStatus.Text() = "Selesai" Then
            Status = 1
        Else
            Status = 0
        End If

        STR = "INSERT INTO pesanan (nama_pelanggan, berat_kg, tanggal_pesanan, tanggal_selesai, status, layanan_id) VALUES (@nama, @berat, @tgl1, @tgl2, @status, @layanan)"
        CMD = New MySqlCommand(STR, CONN)
        CMD.Parameters.AddWithValue("@nama", txtNamaPelanggan.Text)
        CMD.Parameters.AddWithValue("@berat", Val(txtBerat.Text))
        CMD.Parameters.AddWithValue("@tgl1", dtpTanggalPesanan.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@tgl2", dtpTanggalSelesai.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@status", Status)
        CMD.Parameters.AddWithValue("@layanan", idLayanan)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil ditambahkan!!")

        Form6.TampilData()
        Kosong()
    End Sub

    Private Sub txtBerat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBerat.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtBerat.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        cmbStatus.Items.Add("Proses")
        cmbStatus.Items.Add("Selesai")
        cmbStatus.SelectedIndex = 0
        TampilLayanan()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub
End Class