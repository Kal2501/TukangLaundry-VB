Imports MySql.Data.MySqlClient

Public Class Form4

    Dim statusEdit As Boolean = False
    Dim idEdit As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtHarga.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilData()
        AturTampilanGrid()
    End Sub

    Sub TampilData()
        DA = New MySqlDataAdapter("SELECT * FROM paket", CONN)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            idEdit = row.Cells(0).Value
            txtHarga.Text = row.Cells(1).Value.ToString()
            txtLayanan.Text = row.Cells(2).Value.ToString()
            statusEdit = True
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
        MessageBox.Show("Data berhasil diubah!!")
        TampilData()
        Form3.Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not statusEdit Then Exit Sub
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            koneksi()
            CMD = New MySqlCommand("DELETE FROM paket WHERE paket_id=@id", CONN)
            CMD.Parameters.AddWithValue("@id", idEdit)
            CMD.ExecuteNonQuery()
            TampilData()
            Form3.Kosong()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM paket WHERE nama LIKE '%" & txtSearch.Text & "%'", CONN)
        DS = New DataSet()
        DA.Fill(DS, "paket")
        DataGridView1.DataSource = DS.Tables("paket")
    End Sub

End Class