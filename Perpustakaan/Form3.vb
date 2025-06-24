Public Class Form3
    Private namaUserLogin As String
    Private roleUserLogin As String
    Public Sub New()
    End Sub

    ' Constructor yang menerima Nama dan Role dari Form1
    Public Sub New(namaUser As String, roleUser As String)
        InitializeComponent()
        namaUserLogin = namaUser
        roleUserLogin = roleUser
    End Sub

    ' Event yang dijalankan saat form pertama kali dimuat
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If roleUserLogin.Trim().ToLower() = "admin" Then
            ButtonEditBuku.Enabled = True  ' Aktifkan jika Admin
            ButtonEditBuku.Visible = True
        Else
            ButtonEditBuku.Enabled = False ' Nonaktifkan jika bukan Admin
            ' ButtonEditBuku.Visible = False ' Opsional: sembunyikan jika bukan admin
        End If

        ' Setup lain untuk Form3 bisa ditambahkan di sini
    End Sub
    ' Lakukan hal yang sama untuk tombol lain yang mungkin khusus admin
    ' Contoh:
    ' btnManajemenUser.Enabled = Me.currentUserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase)


    ' Event handler untuk tombol Edit Buku (Button2)
    ' Pastikan nama event handler ini sesuai dengan yang ada di file Designer.vb Anda
    ' Biasanya akan otomatis bernama Button2_Click jika dibuat melalui designer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEditBuku.Click ' <<< GANTI DI SINI (Nama Handler & Handles)
        Dim frm5 As New Form5()
        frm5.Show()
        Me.Hide()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm4 As New Form4(namaUserLogin) ' ← Kirim nama ke Form4
        frm4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show
        Close
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm7 As New Form7()
        frm7.Show()
        Me.Hide()
    End Sub
End Class