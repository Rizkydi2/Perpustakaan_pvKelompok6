Public Class Form3
    Private _loggedInUserName As String
    Private _currentUserRole As String

    ' Constructor yang menerima Nama dan Role dari Form1
    Public Sub New(ByVal loggedInUserName As String, ByVal userRole As String)
        InitializeComponent() ' Jangan hapus ini

        ' Simpan nilai yang diterima
        _loggedInUserName = loggedInUserName
        _currentUserRole = userRole
    End Sub

    ' Event yang dijalankan saat form pertama kali dimuat
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _currentUserRole.Trim().ToLower() = "admin" Then
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
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class