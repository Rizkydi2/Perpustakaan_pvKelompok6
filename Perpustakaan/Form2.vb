Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim registerForm As New Form1()
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = "user" ' default, tanpa pilihan

        If username = "" Or password = "" Then
            MessageBox.Show("Silakan isi nama dan password.")
            Exit Sub
        End If

        Dim path As String = Application.StartupPath & "\user.csv"

        ' Cek apakah username sudah ada
        If System.IO.File.Exists(path) Then
            Dim lines() As String = System.IO.File.ReadAllLines(path)
            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                If parts.Length >= 1 AndAlso parts(0) = username Then
                    MessageBox.Show("Username sudah digunakan.")
                    Exit Sub
                End If
            Next
        End If

        ' Simpan data user baru
        Try
            Using sw As System.IO.StreamWriter = System.IO.File.AppendText(path)
                sw.WriteLine(username & "," & password & "," & role)
            End Using
            MessageBox.Show("Akun berhasil dibuat.")
            Form1.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan akun: " & ex.Message)
        End Try
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            Button1.Text = "Hide"
        Else
            txtPassword.UseSystemPasswordChar = True
            Button1.Text = "Show"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class