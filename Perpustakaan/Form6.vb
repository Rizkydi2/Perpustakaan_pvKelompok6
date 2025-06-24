' Di dalam Form6.vb
Imports System.IO
Imports System.Linq
Imports System.Drawing ' Jika perlu warna, tapi tidak dipakai di sini

Public Class Form6

    Private ReadOnly loanCsvPath As String = "loans.csv"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupHistoryListView() ' Panggil setup ListView via kode
        PopulateHistoryListView() ' Panggil pengisian ListView dari loans.csv
    End Sub

    ' --- Sub untuk Setup ListView via Kode ---
    Private Sub SetupHistoryListView()
        ' Pastikan kontrol ada dan tipenya benar
        If Me.Controls.ContainsKey("ListViewHistory") AndAlso TypeOf Me.Controls("ListViewHistory") Is ListView Then
            Dim lv As ListView = DirectCast(Me.Controls("ListViewHistory"), ListView)
            Try
                With lv
                    .Clear() ' Hapus item lama jika ada
                    .Columns.Clear() ' Hapus kolom lama

                    ' Tambahkan Kolom (Sesuaikan Header Text dan Width)
                    .Columns.Add("ID Buku", 60, HorizontalAlignment.Left)
                    .Columns.Add("Judul Buku", 250, HorizontalAlignment.Left)
                    .Columns.Add("Nama Peminjam", 150, HorizontalAlignment.Left)
                    .Columns.Add("Tanggal Pinjam", 120, HorizontalAlignment.Left)

                    ' Atur Properti Penting Lainnya
                    .View = View.Details ' WAJIB
                    .FullRowSelect = True
                    .GridLines = True
                    .MultiSelect = False
                    .HideSelection = False
                End With
            Catch ex As Exception
                MessageBox.Show("Error saat setup ListViewHistory via kode: " & ex.Message, "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Kontrol ListView dengan nama 'ListViewHistory' tidak ditemukan pada Form6.", "Error Desain", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' --- Sub untuk Mengisi ListView dari loans.csv ---
    Private Sub PopulateHistoryListView()
        ' Pastikan kontrol ada
        If Not Me.Controls.ContainsKey("ListViewHistory") OrElse Not TypeOf Me.Controls("ListViewHistory") Is ListView Then Return
        Dim lv As ListView = DirectCast(Me.Controls("ListViewHistory"), ListView)

        lv.Items.Clear() ' Kosongkan list sebelum mengisi

        If Not File.Exists(loanCsvPath) Then
            MessageBox.Show($"File pinjaman '{loanCsvPath}' tidak ditemukan.", "File Tidak Ada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            lv.BeginUpdate() ' Optimasi performa saat menambah banyak item

            Dim loanLines = File.ReadAllLines(loanCsvPath).Skip(1) ' Baca semua baris, lewati header
            For Each line In loanLines
                If String.IsNullOrWhiteSpace(line) Then Continue For
                Dim fields = ParseCsvLine(line) ' Gunakan fungsi parse yang sama
                ' Format: id_buku,judul,nama_peminjam,tanggal_peminjaman
                If fields.Length >= 4 Then
                    Try
                        Dim bookIdStr As String = fields(0) ' ID Buku (Kolom 0)
                        Dim judul As String = fields(1)     ' Judul (Kolom 1)
                        Dim peminjam As String = fields(2)  ' Peminjam (Kolom 2)
                        Dim tanggalPinjamStr As String = "" ' Tanggal (Kolom 3)
                        ' Coba format tanggalnya agar lebih rapi
                        Dim tanggalPinjam As DateTime
                        If DateTime.TryParse(fields(3), tanggalPinjam) Then
                            tanggalPinjamStr = tanggalPinjam.ToString("dd-MM-yyyy") ' Format tanggal saja
                        Else
                            tanggalPinjamStr = fields(3) ' Tampilkan apa adanya jika format salah
                        End If

                        ' Buat ListViewItem baru (Item utama adalah ID Buku)
                        Dim lvi As New ListViewItem(bookIdStr)

                        ' Tambahkan SubItems untuk kolom berikutnya
                        lvi.SubItems.Add(judul)
                        lvi.SubItems.Add(peminjam)
                        lvi.SubItems.Add(tanggalPinjamStr)

                        ' Tidak perlu simpan objek di Tag karena kita tidak pakai Class Loan lagi
                        ' lvi.Tag = ...

                        ' Tambahkan item ke ListView
                        lv.Items.Add(lvi)

                    Catch exParse As Exception
                        Console.WriteLine($"Skipping invalid loan line (error processing): {line} - {exParse.Message}")
                    End Try
                Else
                    Console.WriteLine($"Skipping invalid loan line (wrong number of fields): {line}")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error saat membaca atau mengisi data pinjaman: {ex.Message}", "Error Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lv.EndUpdate() ' Selesaikan update batch
        End Try
    End Sub

    ' --- Fungsi Parse CSV (Salin dari Form5 atau buat jadi Shared Function) ---
    Private Function ParseCsvLine(line As String) As String()
        Dim fields As New List(Of String)
        Dim currentField As New System.Text.StringBuilder()
        Dim inQuotes As Boolean = False
        For i As Integer = 0 To line.Length - 1
            Dim currentChar As Char = line(i)
            If currentChar = """"c Then
                If inQuotes AndAlso i + 1 < line.Length AndAlso line(i + 1) = """"c Then
                    currentField.Append("""")
                    i += 1
                Else
                    inQuotes = Not inQuotes
                End If
            ElseIf currentChar = ","c AndAlso Not inQuotes Then
                fields.Add(currentField.ToString())
                currentField.Clear()
            Else
                currentField.Append(currentChar)
            End If
        Next
        fields.Add(currentField.ToString())
        Return fields.Select(Function(f) f.Trim()).ToArray()
    End Function

    ' --- Event Handler Tombol Back ---
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click ' Sesuaikan nama tombol Back
        Dim frm As New Form3()
        frm.Show()
        Me.Close()
    End Sub

End Class