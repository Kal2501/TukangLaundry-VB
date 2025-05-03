Imports MySql.Data.MySqlClient

Public Class Form1

    Sub Kosong()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Isi semua data.")
            Exit Sub
        End If

        Try
            koneksi()
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            Dim STR As String = "SELECT * FROM user WHERE username = @username AND password = @password"
            Dim CMD As New MySqlCommand(STR, CONN)
            CMD.Parameters.AddWithValue("@username", txtUsername.Text)
            CMD.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim reader As MySqlDataReader = CMD.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login berhasil!")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau password salah!")
                Kosong()
            End If

            reader.Close()
            CONN.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
End Class
