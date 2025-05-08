Imports MySql.Data.MySqlClient

Public Class DetailPelanggan
    Public Shared statusEdit As Boolean = False
    Public Shared idEdit As Integer

    Sub Kosong()
        txtNama.Clear()
        txtBerat.Clear()
        cmbStatus.SelectedIndex = 0
        cmbLayanan.SelectedIndex = -1
        dtpPesanan.Value = Now
        dtpSelesai.Value = Now
        statusEdit = False
    End Sub

    Sub TampilLayanan()
        CMD = New MySqlCommand("SELECT * FROM paket", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            cmbLayanan.Items.Add(RD("paket_id") & " - " & RD("nama") & " (@Rp" & RD("harga_per_kg") & ")")
        End While
        RD.Close()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not statusEdit Then Exit Sub
        koneksi()
        Dim idLayanan As Integer = Val(Split(cmbLayanan.Text, " - ")(0))
        Dim StatusCuci As Boolean
        If dtpSelesai.Value < dtpPesanan.Value Then
            MessageBox.Show("Tanggal selesai tidak boleh lebih awal dari tanggal pesanan!")
            Exit Sub
        End If
        If cmbStatus.Text = "Selesai" Then
            StatusCuci = 1
        Else
            StatusCuci = 0
        End If

        STR = "UPDATE pesanan SET nama_pelanggan=@nama, berat_kg=@berat, tanggal_pesanan=@tgl1, tanggal_selesai=@tgl2, status=@status, layanan_id=@layanan WHERE pesanan_id=@id"
        CMD = New MySqlCommand(STR, CONN)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@berat", Val(txtBerat.Text))
        CMD.Parameters.AddWithValue("@tgl1", dtpPesanan.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@tgl2", dtpSelesai.Value.ToString("yyyy-MM-dd"))
        CMD.Parameters.AddWithValue("@status", StatusCuci)
        CMD.Parameters.AddWithValue("@layanan", idLayanan)
        CMD.Parameters.AddWithValue("@id", idEdit)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diubah!")
        DataPelanggan.Show()
        Me.Close()
        Kosong()
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not statusEdit Then Exit Sub
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM pesanan WHERE pesanan_id=@id", CONN)
            CMD.Parameters.AddWithValue("@id", idEdit)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            DataPelanggan.Show()
            Me.Close()
            Kosong()
        End If
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

    Private Sub DetailPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilLayanan()
        cmbStatus.Items.Add("Proses")
        cmbStatus.Items.Add("Selesai")
    End Sub
End Class