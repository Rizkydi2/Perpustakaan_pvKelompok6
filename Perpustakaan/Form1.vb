' Di dalam Class Form1 pada file Form1.vb
Imports System.IO

Public Class Form1

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim inputUsername As String = TextBoxUsername.Text.Trim() ' Nama user yang diinput
        Dim inputPassword As String = TextBoxPassword.Text
        Dim userCsvPath As String = "user.csv" ' Pastikan file ini ada

        Dim loginBerhasil As Boolean = False
        Dim namaUserYangLogin As String = "" ' Untuk dikirim ke Form3 -> Form4
        Dim roleUserYangLogin As String = "" ' Untuk dikirim ke Form3

        If String.IsNullOrWhiteSpace(inputUsername) OrElse String.IsNullOrWhiteSpace(inputPassword) Then
            MessageBox.Show("Username dan password harus diisi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not File.Exists(userCsvPath) Then
            MessageBox.Show($"File pengguna '{userCsvPath}' tidak ditemukan.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Baca user.csv -> Format: username,password,role
            Dim lines() As String = File.ReadAllLines(userCsvPath)

            ' Lewati header jika baris pertama adalah header
            Dim startIndex As Integer = 0
            If lines.Length > 0 AndAlso lines(0).Trim().ToLower() = "username,password,role" Then
                startIndex = 1
            End If

            ' Loop mulai dari data (setelah header jika ada)
            For i As Integer = startIndex To lines.Length - 1
                Dim line As String = lines(i)
                If String.IsNullOrWhiteSpace(line) Then Continue For ' Lewati baris kosong

                Dim fields = line.Split(","c) ' Pisahkan dengan koma

                ' Pastikan ada 3 kolom
                If fields.Length >= 3 Then
                    Dim csvUsername As String = fields(0).Trim()
                    Dim csvPassword As String = fields(1) ' Password dari CSV
                    Dim csvRole As String = fields(2).Trim() ' Role dari CSV

                    ' Bandingkan username (case-insensitive) dan password (case-sensitive)
                    If csvUsername.Equals(inputUsername, StringComparison.OrdinalIgnoreCase) AndAlso csvPassword.Equals(inputPassword, StringComparison.Ordinal) Then
                        loginBerhasil = True
                        namaUserYangLogin = csvUsername ' Simpan Nama/Username
                        roleUserYangLogin = csvRole     ' Simpan Role
                        Exit For ' User ditemukan, hentikan pencarian
                    End If
                End If
            Next

            ' Cek hasil login setelah loop selesai
            If loginBerhasil Then
                MessageBox.Show("Login berhasil!.")
                ' Jika berhasil, buka Form3 dan kirim NAMA serta ROLE
                Dim frm3 As New Form3(namaUserYangLogin, roleUserYangLogin)
                frm3.Show()
                Me.Hide()

            Else
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBoxPassword.Clear()
                TextBoxPassword.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan saat proses login: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Kode untuk Tombol Show/Hide Password (Pastikan ada)
    Private Sub ButtonShowPassword_Click(sender As Object, e As EventArgs) Handles ButtonShowPassword.Click
        If TextBoxPassword.UseSystemPasswordChar = True Then
            TextBoxPassword.UseSystemPasswordChar = False
            ButtonShowPassword.Text = "Hide"
        Else
            TextBoxPassword.UseSystemPasswordChar = True
            ButtonShowPassword.Text = "Show"
        End If
    End Sub

    ' Kode untuk Tombol Sign Up (Jika masih relevan)
    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click ' Sesuaikan nama tombol
        Dim frm2 As New Form2()
        frm2.Show()
        Me.Hide()
    End Sub

    ' Kode untuk Tombol Close (Jika ada)
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click ' Sesuaikan nama tombol
        Application.Exit()
    End Sub

End Class