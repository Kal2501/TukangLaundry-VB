Imports MySql.Data.MySqlClient

Public Class DetailLayanan
    Public Shared statusEdit As Boolean = False
    Public Shared idEdit As Integer

    Sub Kosong()
        txtLayanan.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtHarga.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not statusEdit Then Exit Sub
        koneksi()
        STR = "UPDATE paket SET harga_per_kg = @harga_per_kg, nama = @nama WHERE paket_id = @id"
        CMD = New MySqlCommand(STR, CONN)
        CMD.Parameters.AddWithValue("@harga_per_kg", Val(txtHarga.Text))
        CMD.Parameters.AddWithValue("@nama", txtLayanan.Text)
        CMD.Parameters.AddWithValue("@id", idEdit)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah!")
        DataLayanan.Show()
        Me.Close()
        Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not statusEdit Then Exit Sub
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM paket WHERE paket_id=@id", CONN)
            CMD.Parameters.AddWithValue("@id", idEdit)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            DataLayanan.Show()
            Me.Close()
            Kosong()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataLayanan.Show()
        Me.Close()
    End Sub

    Private Sub DetailLayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class