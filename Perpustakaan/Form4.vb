' Di dalam Form4.vb
Imports System.IO
Imports System.Linq
Imports System.Drawing

'===========================================================
'==> MULAI DEFINISI CLASS Form4 (Harus Pertama di file ini) <==
'===========================================================
Public Class Form4
    Private namaUserLogin As String

    Public Sub New(namaUser As String)
        InitializeComponent()
        namaUserLogin = namaUser
    End Sub

    ' Tidak ada lagi _loggedInUserName
    Private allBooks As New List(Of Book)
    Private currentLoans As New List(Of Loan)
    Private ReadOnly bookCsvPath As String = "book.csv"
    Private ReadOnly loanCsvPath As String = "loans.csv"

    ' === Constructor Default (Tanpa parameter) ===
    Public Sub New()
        InitializeComponent()
    End Sub
    ' ============================================
    Public Sub IsiJudulBuku(judul As String)
        TextBoxJudulPinjam.Text = judul
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === Nama Peminjam KOSONG dan BISA DIEDIT ===
        TextBoxNamaPeminjam.Text = namaUserLogin
        TampilkanDaftarPinjamanUserSendiri()

        SetupListViews() ' Panggil setup via kode

        LoadBooks()
        LoadLoans()
        UpdateBookAvailabilityFromLoans()
        RefreshListViews()
    End Sub

    ' --- Sub Setup ListView via Kode (Dengan ListView2, Status di ListView1) ---
    Private Sub SetupListViews()
        Try
            With ListView1 ' Untuk Buku Tersedia
                .Clear()
                .Columns.Clear()
                .Columns.Add("ID", 40, HorizontalAlignment.Left)
                .Columns.Add("Judul", 200, HorizontalAlignment.Left)
                .Columns.Add("Penulis", 150, HorizontalAlignment.Left)
                .Columns.Add("Tahun", 60, HorizontalAlignment.Left)
                .Columns.Add("Kategori", 100, HorizontalAlignment.Left)
                .Columns.Add("Status", 80, HorizontalAlignment.Left) ' Kolom Status
                .View = View.Details
                .FullRowSelect = True
                .GridLines = True
                .MultiSelect = False
                .HideSelection = False
            End With
            With ListView2 ' Untuk Buku Dipinjam
                .Clear()
                .Columns.Clear()
                .Columns.Add("Judul Buku", 200, HorizontalAlignment.Left)
                .Columns.Add("Peminjam", 150, HorizontalAlignment.Left)
                .Columns.Add("Tgl Pinjam", 100, HorizontalAlignment.Left)
                .View = View.Details
                .FullRowSelect = True
                .GridLines = True
                .MultiSelect = False
                .HideSelection = False
            End With
        Catch ex As Exception
            MessageBox.Show("Error saat setup ListView via kode: " & ex.Message, "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Fungsi Memuat Data (LoadBooks, LoadLoans, UpdateBookAvailabilityFromLoans sama) ---
    ' (Salin kode LoadBooks, LoadLoans, UpdateBookAvailabilityFromLoans dari jawaban sebelumnya)
    Private Sub LoadBooks()
        allBooks.Clear()
        If Not File.Exists(bookCsvPath) Then
            MessageBox.Show($"File '{bookCsvPath}' tidak ditemukan. Pastikan file ada di '{Application.StartupPath}'.", "Error File Buku", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Using reader As New StreamReader(bookCsvPath)
                If Not reader.EndOfStream Then reader.ReadLine() ' Skip header
                While Not reader.EndOfStream
                    Dim line = reader.ReadLine()
                    If String.IsNullOrWhiteSpace(line) Then Continue While
                    Dim fields = line.Split(","c)
                    If fields.Length >= 5 Then
                        Try
                            Dim newBook As New Book With {
                                .Id = Integer.Parse(fields(0).Trim()),
                                .Judul = fields(1).Trim(),
                                .Penulis = fields(2).Trim(),
                                .Tahun = Integer.Parse(fields(3).Trim()),
                                .Kategori = fields(4).Trim(),
                                .IsAvailable = True
                            }
                            allBooks.Add(newBook)
                        Catch exParse As FormatException
                            Console.WriteLine($"Skipping invalid book line (parse error): {line} - {exParse.Message}")
                        End Try
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saat membaca {bookCsvPath}: {ex.Message}", "Error Membaca File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadLoans()
        currentLoans.Clear()
        If Not File.Exists(loanCsvPath) Then
            Try
                File.WriteAllText(loanCsvPath, "id_buku,judul,nama_peminjam,tanggal_peminjaman" & vbCrLf)
            Catch ex As Exception
                MessageBox.Show($"Gagal membuat file {loanCsvPath}: {ex.Message}", "Error Membuat File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Return
        End If
        Try
            Using reader As New StreamReader(loanCsvPath)
                If Not reader.EndOfStream Then reader.ReadLine() ' Skip header
                While Not reader.EndOfStream
                    Dim line = reader.ReadLine()
                    If String.IsNullOrWhiteSpace(line) Then Continue While
                    Dim fields = line.Split(","c)
                    If fields.Length >= 4 Then
                        Try
                            Dim newLoan As New Loan With {
                                .BookId = Integer.Parse(fields(0).Trim()),
                                .JudulBuku = fields(1).Trim(),
                                .NamaPeminjam = fields(2).Trim(),
                                .TanggalPinjam = Date.Parse(fields(3).Trim())
                            }
                            currentLoans.Add(newLoan)
                        Catch exParse As FormatException
                            Console.WriteLine($"Skipping invalid loan line (parse error): {line} - {exParse.Message}")
                        Catch exParse As Exception
                            Console.WriteLine($"Skipping invalid loan line (general parse error): {line} - {exParse.Message}")
                        End Try
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saat membaca {loanCsvPath}: {ex.Message}", "Error Membaca File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBookAvailabilityFromLoans()
        For Each book In allBooks
            book.IsAvailable = Not currentLoans.Any(Function(loan) loan.BookId = book.Id)
        Next
    End Sub


    ' --- Fungsi Memperbarui Tampilan ListView (Dengan Dua ListView + Filter) ---
    Private Sub RefreshListViews(Optional titleFilter As String = Nothing)
        Try
            ListView1.BeginUpdate()
            ListView2.BeginUpdate()
            ListView1.Items.Clear()
            ListView2.Items.Clear()

            ' Filter data untuk ListView1 (HANYA YANG TERSEDIA)
            Dim availableBooksQuery = allBooks.Where(Function(b) b.IsAvailable)
            If Not String.IsNullOrWhiteSpace(titleFilter) Then
                Dim lowerFilter = titleFilter.ToLower()
                availableBooksQuery = availableBooksQuery.Where(Function(b) b.Judul.ToLower().StartsWith(lowerFilter))
            End If
            Dim booksToShowInListView1 = availableBooksQuery.ToList()

            ' Isi ListView1
            For Each book In booksToShowInListView1
                Dim lvi As New ListViewItem(book.Id.ToString())
                lvi.SubItems.Add(book.Judul)
                lvi.SubItems.Add(book.Penulis)
                lvi.SubItems.Add(book.Tahun.ToString())
                lvi.SubItems.Add(book.Kategori)
                lvi.SubItems.Add("Tersedia") ' Kolom Status
                lvi.Tag = book
                ListView1.Items.Add(lvi)
            Next

            ' Isi ListView2
            For Each loan In currentLoans
                Dim lvi As New ListViewItem(loan.JudulBuku)
                lvi.SubItems.Add(loan.NamaPeminjam)
                lvi.SubItems.Add(loan.TanggalPinjam.ToString("dd-MM-yyyy"))
                lvi.Tag = loan
                ListView2.Items.Add(lvi)
            Next

            TextBoxJudulKembali.Clear()
            ListView1.SelectedItems.Clear()
            ListView2.SelectedItems.Clear()

        Catch ex As Exception
            MessageBox.Show("Error saat refresh ListView: " & ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ListView1.EndUpdate()
            ListView2.EndUpdate()
        End Try
    End Sub

    ' --- Event Handler Interaksi User ---
    Private Sub TextBoxJudulPinjam_TextChanged(sender As Object, e As EventArgs) Handles TextBoxJudulPinjam.TextChanged
        RefreshListViews(TextBoxJudulPinjam.Text)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedBook As Book = TryCast(ListView1.SelectedItems(0).Tag, Book)
            If selectedBook IsNot Nothing Then
                TextBoxJudulPinjam.Text = selectedBook.Judul
                TextBoxJudulKembali.Clear()
                If ListView2.SelectedItems.Count > 0 Then ListView2.SelectedItems(0).Selected = False
            End If
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            Dim selectedLoan As Loan = TryCast(ListView2.SelectedItems(0).Tag, Loan)
            If selectedLoan IsNot Nothing Then
                TextBoxJudulKembali.Text = selectedLoan.JudulBuku
                If ListView1.SelectedItems.Count > 0 Then ListView1.SelectedItems(0).Selected = False
                ' Isi nama peminjam di textbox saat memilih dari list pinjaman
                TextBoxNamaPeminjam.Text = selectedLoan.NamaPeminjam
            End If
        Else
            TextBoxJudulKembali.Clear()
        End If
    End Sub

    Private Sub ButtonPinjam_Click(sender As Object, e As EventArgs) Handles ButtonPinjam.Click
        Dim judulDipilih As String = TextBoxJudulPinjam.Text.Trim().ToLower()
        Dim selectedBook As Book = allBooks.FirstOrDefault(Function(b) b.Judul.ToLower() = judulDipilih)

        If selectedBook Is Nothing Then
            MessageBox.Show("Buku tidak ditemukan.")
            Return
        End If

        ' === Ambil nama peminjam dari TextBox ===
        Dim namaPeminjam = TextBoxNamaPeminjam.Text.Trim()
        If String.IsNullOrWhiteSpace(namaPeminjam) Then
            MessageBox.Show("Silakan masukkan nama peminjam.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNamaPeminjam.Focus()
            Return
        End If
        ' ========================================

        If Not selectedBook.IsAvailable Then
            MessageBox.Show($"Buku '{selectedBook.Judul}' tidak tersedia saat ini.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshListViews()
            Return
        End If

        Dim tempLoan As Loan = Nothing
        Try
            tempLoan = New Loan With {
                .BookId = selectedBook.Id,
                .JudulBuku = selectedBook.Judul,
                .NamaPeminjam = namaPeminjam, ' <-- Gunakan nama dari TextBox
                .TanggalPinjam = Date.Now
            }
            currentLoans.Add(tempLoan)
            Dim loanRecord As String = $"{tempLoan.BookId},{tempLoan.JudulBuku},{tempLoan.NamaPeminjam},{tempLoan.TanggalPinjam:yyyy-MM-dd}"
            Using writer As New StreamWriter(loanCsvPath, True)
                writer.WriteLine(loanRecord)
            End Using
            selectedBook.IsAvailable = False

            RefreshListViews()

            MessageBox.Show($"Buku '{selectedBook.Judul}' berhasil dipinjam oleh {namaPeminjam}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNamaPeminjam.Clear() ' Clear setelah pinjam
            TextBoxJudulPinjam.Clear()

        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan saat memproses peminjaman: {ex.Message}", "Error Peminjaman", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If tempLoan IsNot Nothing Then currentLoans.Remove(tempLoan)
            If selectedBook IsNot Nothing Then selectedBook.IsAvailable = True
            RefreshListViews()
        End Try
    End Sub

    Private Sub ButtonKembalikan_Click(sender As Object, e As EventArgs) Handles ButtonKembalikan.Click
        If ListView2.SelectedItems.Count = 0 Then
            MessageBox.Show("Silakan pilih buku yang ingin dikembalikan dari daftar pinjaman.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedLoan As Loan = TryCast(ListView2.SelectedItems(0).Tag, Loan)
        If selectedLoan Is Nothing Then Return

        Dim bookToReturn As Book = allBooks.FirstOrDefault(Function(b) b.Id = selectedLoan.BookId)

        Try
            currentLoans.Remove(selectedLoan)
            RewriteLoansCsv()

            If bookToReturn IsNot Nothing Then
                bookToReturn.IsAvailable = True
            Else
                Console.WriteLine($"Peringatan: Buku asli dengan ID {selectedLoan.BookId} tidak ditemukan saat pengembalian.")
            End If

            RefreshListViews()

            MessageBox.Show($"Buku '{selectedLoan.JudulBuku}' telah dikembalikan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNamaPeminjam.Clear() ' Clear juga setelah kembali
            TextBoxJudulKembali.Clear()

        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan saat memproses pengembalian: {ex.Message}", "Error Pengembalian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If selectedLoan IsNot Nothing AndAlso bookToReturn IsNot Nothing Then
                currentLoans.Add(selectedLoan)
                bookToReturn.IsAvailable = False
            End If
            RefreshListViews()
        End Try
    End Sub

    ' --- Fungsi Bantu RewriteLoansCsv ---
    Private Sub RewriteLoansCsv()
        Try
            Dim linesToWrite As New List(Of String)
            linesToWrite.Add("id_buku,judul,nama_peminjam,tanggal_peminjaman")
            For Each loan In currentLoans
                linesToWrite.Add($"{loan.BookId},{loan.JudulBuku},{loan.NamaPeminjam},{loan.TanggalPinjam:yyyy-MM-dd}")
            Next
            File.WriteAllLines(loanCsvPath, linesToWrite)
        Catch ex As Exception
            MessageBox.Show($"Gagal menulis ulang file {loanCsvPath}: {ex.Message}", "Error Penulisan File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBoxNamaPeminjam_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNamaPeminjam.TextChanged

    End Sub
    Private Sub TampilkanDaftarPinjamanUserSendiri()
        ListView2.Items.Clear()

        Dim path As String = "loans.csv"
        If Not File.Exists(path) Then Return

        Dim lines() As String = File.ReadAllLines(path)

        For i As Integer = 1 To lines.Length - 1 ' Skip header
            Dim data() As String = lines(i).Split(","c)
            If data.Length >= 4 Then
                Dim judul = data(1).Trim()
                Dim peminjam = data(2).Trim()
                Dim tanggal = data(3).Trim()

                ' Filter hanya buku yang dipinjam oleh user login
                If peminjam.Equals(namaUserLogin, StringComparison.OrdinalIgnoreCase) Then
                    Dim item As New ListViewItem(judul)
                    item.SubItems.Add(peminjam)
                    item.SubItems.Add(tanggal)
                    ListView2.Items.Add(item)
                End If
            End If
        Next
    End Sub
End Class ' <<<<<< AKHIR DARI CLASS FORM4


'===========================================================
'==> DEFINISI CLASS BOOK DITARUH SETELAH Form4 <==
'===========================================================
Public Class Book
    ' ... (Kode Class Book sama seperti sebelumnya) ...
    Public Property Id As Integer
    Public Property Judul As String
    Public Property Penulis As String
    Public Property Tahun As Integer
    Public Property Kategori As String
    Public Property IsAvailable As Boolean = True

    Public Overrides Function ToString() As String
        Return $"{Judul} oleh {Penulis} ({Tahun}) - {Kategori}"
    End Function
End Class

'===========================================================
'==> DEFINISI CLASS LOAN DITARUH SETELAH Form4 <==
'===========================================================
Public Class Loan
    ' ... (Kode Class Loan sama seperti sebelumnya) ...
    Public Property BookId As Integer
    Public Property JudulBuku As String
    Public Property NamaPeminjam As String
    Public Property TanggalPinjam As Date

    Public Overrides Function ToString() As String
        Return $"{JudulBuku} - Oleh: {NamaPeminjam} (Dipinjam: {TanggalPinjam:dd-MM-yyyy})"
    End Function
End Class