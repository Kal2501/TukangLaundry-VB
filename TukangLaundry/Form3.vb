Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Sub Kosong()
        txtLayanan.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtHarga.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs)
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

        MessageBox.Show("Data berhasil ditambahkan!!")
        Form4.TampilData()
        Kosong()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs)
        Kosong()
    End Sub

End Class