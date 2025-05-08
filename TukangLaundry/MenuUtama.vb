Public Class MenuUtama

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataLayanan.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataPelanggan.Show()
        Me.Close()
    End Sub
End Class