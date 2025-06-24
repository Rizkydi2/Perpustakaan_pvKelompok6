Imports System.IO

Public Class Form7
    Private isUpdatingComboBox As Boolean = False
    Private Class Buku
        Public Property Judul As String
        Public Property Penulis As String
        Public Property Tahun As String
        Public Property Kategori As String
    End Class

    Private bukuList As New List(Of Buku)
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = "book.csv"
        If File.Exists(path) Then
            Dim lines() As String = File.ReadAllLines(path)
            For i As Integer = 1 To lines.Length - 1 ' Skip header
                Dim data() As String = lines(i).Split(","c)
                Dim bukuBaru As New Buku With {
                .Judul = data(1).Trim(),
                .Penulis = data(2).Trim(),
                .Tahun = data(3).Trim(),
                .Kategori = data(4).Trim()
            }
                bukuList.Add(bukuBaru)
                ComboBoxJudul.Items.Add(bukuBaru.Judul)
            Next
        End If
    End Sub
    Private Sub ComboBoxJudul_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxJudul.TextUpdate
        If isUpdatingComboBox Then Return

        Dim keyword As String = ComboBoxJudul.Text.ToLower()
        Dim hasil = bukuList.
        Where(Function(b) b.Judul.ToLower().Contains(keyword)).
        OrderBy(Function(b) If(b.Judul.ToLower().StartsWith(keyword), 0, 1)).
        ThenBy(Function(b) b.Judul).
        ToList()

        isUpdatingComboBox = True
        ComboBoxJudul.Items.Clear()
        For Each buku In hasil
            ComboBoxJudul.Items.Add(buku.Judul)
        Next

        ' Atur jumlah item dropdown
        ComboBoxJudul.IntegralHeight = False
        ComboBoxJudul.MaxDropDownItems = If(hasil.Count >= 5, 5, Math.Max(1, hasil.Count))

        ' Tampilkan dropdown (otomatis terbuka saat ngetik)
        If ComboBoxJudul.Items.Count > 0 Then
            ComboBoxJudul.DroppedDown = (hasil.Count > 1)

        End If


        ' Jaga posisi kursor tidak loncat
        ComboBoxJudul.SelectionStart = ComboBoxJudul.Text.Length
        ComboBoxJudul.SelectionLength = 0
        isUpdatingComboBox = False
    End Sub
    Private Sub ComboBoxJudul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJudul.SelectedIndexChanged
        TampilkanDetailBuku(ComboBoxJudul.Text)
    End Sub

    Private Sub ComboBoxJudul_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxJudul.TextChanged
        TampilkanDetailBuku(ComboBoxJudul.Text)
    End Sub

    Private Sub TampilkanDetailBuku(judulDicari As String)
        For Each buku In bukuList
            If buku.Judul.ToLower() = judulDicari.ToLower() Then
                LabelPenulis.Text = buku.Penulis
                LabelTahun.Text = buku.Tahun
                LabelKategori.Text = buku.Kategori
                Exit For
            End If
        Next
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim judulDipilih As String = ComboBoxJudul.Text.Trim()
        If String.IsNullOrWhiteSpace(judulDipilih) Then
            MessageBox.Show("Pilih judul buku terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim formPeminjaman As New Form4()
        formPeminjaman.IsiJudulBuku(judulDipilih)
        formPeminjaman.Show()
        Me.Hide() ' <-- Optional: sembunyikan form sekarang
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LabelTahun.Click

    End Sub
End Class