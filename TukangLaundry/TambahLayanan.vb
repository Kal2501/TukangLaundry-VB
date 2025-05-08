Imports MySql.Data.MySqlClient

Public Class TambahLayanan

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtHarga.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Sub Kosong()
        txtLayanan.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtLayanan.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Isi semua data.")
            Exit Sub
        End If

        koneksi()
        STR = "INSERT INTO paket (harga_per_kg, nama) VALUES (@harga_per_kg, @nama)"
        CMD = New MySqlCommand(STR, CONN)
        CMD.Parameters.AddWithValue("@harga_per_kg", Val(txtHarga.Text))
        CMD.Parameters.AddWithValue("@nama", txtLayanan.Text)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data layanan berhasil ditambahkan!")
        Kosong()
    End Sub


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        DataLayanan.Show()
        Me.Close()
    End Sub

    Private Sub TambahLayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class