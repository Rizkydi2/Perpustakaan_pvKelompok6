' Di dalam Form5.vb
Imports System.IO
Imports System.Linq
Imports System.Text ' Untuk StringBuilder saat menyimpan CSV
Imports System.Data ' Diperlukan untuk DataTable

'===========================================================
'==> MULAI DEFINISI CLASS Form5 (Harus Pertama di file ini) <==
'===========================================================
Public Class Form5

    ' Gunakan DataTable untuk menampung data gabungan buku dan status
    Private bookDataTable As New DataTable("Books")
    Private ReadOnly bookCsvPath As String = "book.csv"
    Private ReadOnly loanCsvPath As String = "loans.csv"

    ' Untuk menyimpan ID buku yang sedang dipilih untuk diedit
    Private _selectedBookIdForEdit As Integer? = Nothing ' Nullable Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefineDataTableColumns() ' Definisikan kolom DataTable sekali saja
        LoadDataAndRefreshGrid() ' Panggil fungsi utama untuk load & refresh
        ClearInputFields()
        ButtonEditBuku.Enabled = False
    End Sub

    ' --- Definisikan struktur DataTable ---
    Private Sub DefineDataTableColumns()
        bookDataTable = New DataTable("Books") ' Buat instance baru
        ' Hapus kolom lama jika ada (untuk pemanggilan ulang)
        bookDataTable.Columns.Clear()
        ' Tambahkan kolom sesuai yang ingin ditampilkan di grid
        bookDataTable.Columns.Add("ID", GetType(Integer)) ' Primary key?
        bookDataTable.Columns.Add("Judul", GetType(String))
        bookDataTable.Columns.Add("Penulis", GetType(String))
        bookDataTable.Columns.Add("Tahun", GetType(Integer))
        bookDataTable.Columns.Add("Kategori", GetType(String))
        bookDataTable.Columns.Add("Status", GetType(String))

        ' Opsional: Set primary key jika diperlukan
        ' bookDataTable.PrimaryKey = New DataColumn() {bookDataTable.Columns("ID")}
    End Sub

    ' --- Fungsi Utama untuk Memuat Data dan Merefresh Grid ---
    Private Sub LoadDataAndRefreshGrid()
        PopulateDataTableFromCsv() ' Isi DataTable dari CSV
        BindDataToGrid()           ' Bind DataTable ke Grid
        FormatDataGridView()       ' Format tampilan Grid
    End Sub

    ' --- Fungsi untuk Memuat CSV ke DataTable ---
    Private Sub PopulateDataTableFromCsv()
        bookDataTable.Rows.Clear() ' Kosongkan data lama

        ' 1. Muat ID buku yang sedang dipinjam
        Dim borrowedBookIds As New HashSet(Of Integer)
        If File.Exists(loanCsvPath) Then
            Try
                Dim loanLines = File.ReadAllLines(loanCsvPath).Skip(1) ' Baca semua baris, lewati header
                For Each line In loanLines
                    If String.IsNullOrWhiteSpace(line) Then Continue For
                    Dim fields = ParseCsvLine(line) ' Gunakan parse yg lebih baik
                    If fields.Length >= 1 Then
                        Dim bookId As Integer
                        If Integer.TryParse(fields(0), bookId) Then
                            borrowedBookIds.Add(bookId)
                        End If
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error membaca file pinjaman (loans.csv): " & ex.Message, "Error Load Loans", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

        ' 2. Muat buku dan tentukan statusnya
        If Not File.Exists(bookCsvPath) Then
            MessageBox.Show($"File '{bookCsvPath}' tidak ditemukan. Pastikan file ada di '{Application.StartupPath}'.", "Error File Buku", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim bookLines = File.ReadAllLines(bookCsvPath).Skip(1) ' Baca semua baris, lewati header
            For Each line In bookLines
                If String.IsNullOrWhiteSpace(line) Then Continue For
                Dim fields = ParseCsvLine(line)
                If fields.Length >= 5 Then
                    Try
                        Dim bookId As Integer = Integer.Parse(fields(0))
                        Dim judul As String = fields(1)
                        Dim penulis As String = fields(2)
                        Dim tahun As Integer = Integer.Parse(fields(3))
                        Dim kategori As String = fields(4)

                        ' Tentukan status berdasarkan ID buku
                        Dim status As String = If(borrowedBookIds.Contains(bookId), "Dipinjam", "Tersedia")

                        ' Tambahkan baris ke DataTable
                        bookDataTable.Rows.Add(bookId, judul, penulis, tahun, kategori, status)

                    Catch exParse As FormatException
                        Console.WriteLine($"Skipping invalid book line (parse error): {line} - {exParse.Message}")
                    Catch exConv As Exception ' Tangkap error konversi lainnya
                        Console.WriteLine($"Skipping invalid book line (conversion error): {line} - {exConv.Message}")
                    End Try
                Else
                    Console.WriteLine($"Skipping invalid book line (wrong number of fields): {line}")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error saat membaca {bookCsvPath}: {ex.Message}", "Error Membaca File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi Parse CSV sederhana (handle quoted fields) - Tetap diperlukan
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

    ' --- Fungsi Binding Data ke DataGridView ---
    Private Sub BindDataToGrid()
        If Not Me.Controls.ContainsKey("DataGridViewStatusBuku") OrElse Not TypeOf Me.Controls("DataGridViewStatusBuku") Is DataGridView Then Return
        Dim dgv As DataGridView = DirectCast(Me.Controls("DataGridViewStatusBuku"), DataGridView)
        Try
            ' Simpan ID yang sedang dipilih jika ada
            Dim currentSelectedId As Integer? = Nothing
            If dgv.SelectedRows.Count > 0 Then
                If dgv.SelectedRows(0).Cells("ID").Value IsNot Nothing AndAlso IsNumeric(dgv.SelectedRows(0).Cells("ID").Value) Then
                    currentSelectedId = CInt(dgv.SelectedRows(0).Cells("ID").Value)
                End If
            End If

            dgv.DataSource = Nothing
            ' Sortir DataTable berdasarkan ID (opsional)
            Dim dv As DataView = bookDataTable.DefaultView
            dv.Sort = "ID ASC" ' Urutkan berdasarkan kolom ID
            dgv.DataSource = dv ' Bind ke DataView yang sudah diurutkan
            ' Atau bind langsung: dgv.DataSource = bookDataTable

            ' Coba kembalikan seleksi
            TryRestoreSelection(currentSelectedId)

        Catch ex As Exception
            MessageBox.Show("Error saat binding data ke Grid: " & ex.Message, "Binding Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Fungsi Setup & Formatting DataGridView (Nama Kolom = Nama di DataTable) ---
    Private Sub FormatDataGridView()
        Try
            If Me.Controls.ContainsKey("DataGridViewStatusBuku") AndAlso TypeOf Me.Controls("DataGridViewStatusBuku") Is DataGridView Then
                Dim dgv As DataGridView = DirectCast(Me.Controls("DataGridViewStatusBuku"), DataGridView)

                dgv.AllowUserToAddRows = False
                dgv.AllowUserToDeleteRows = False
                dgv.ReadOnly = True
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgv.MultiSelect = False
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

                ' Atur Header dan Lebar Kolom (Nama Kolom SESUAIKAN dgn DataTable)
                If dgv.Columns.Contains("ID") Then
                    dgv.Columns("ID").HeaderText = "ID"
                    dgv.Columns("ID").Width = 40
                    dgv.Columns("ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                End If
                If dgv.Columns.Contains("Judul") Then
                    dgv.Columns("Judul").HeaderText = "Judul Buku"
                    dgv.Columns("Judul").FillWeight = 40
                End If
                If dgv.Columns.Contains("Penulis") Then
                    dgv.Columns("Penulis").HeaderText = "Penulis"
                    dgv.Columns("Penulis").FillWeight = 30
                End If
                If dgv.Columns.Contains("Tahun") Then
                    dgv.Columns("Tahun").HeaderText = "Tahun"
                    dgv.Columns("Tahun").Width = 60
                    dgv.Columns("Tahun").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                End If
                If dgv.Columns.Contains("Kategori") Then
                    dgv.Columns("Kategori").HeaderText = "Kategori"
                    dgv.Columns("Kategori").FillWeight = 25
                End If
                If dgv.Columns.Contains("Status") Then
                    dgv.Columns("Status").HeaderText = "Status"
                    dgv.Columns("Status").Width = 80
                    dgv.Columns("Status").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                End If

                ' Beri warna pada baris berdasarkan status
                For Each row As DataGridViewRow In dgv.Rows
                    If row.Cells("Status").Value IsNot Nothing AndAlso row.Cells("Status").Value.ToString() = "Dipinjam" Then
                        row.DefaultCellStyle.ForeColor = Color.Gray
                    Else
                        row.DefaultCellStyle.ForeColor = SystemColors.ControlText
                    End If
                Next

            Else
                MessageBox.Show("Kontrol DataGridView 'DataGridViewStatusBuku' tidak ditemukan.", "Error Desain", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat format DataGridView: " & ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' --- Event Handler untuk Seleksi Grid ---
    Private Sub DataGridViewStatusBuku_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewStatusBuku.SelectionChanged
        If DataGridViewStatusBuku.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewStatusBuku.SelectedRows(0)

            ' Ambil data dari sel berdasarkan nama kolom DataTable
            Try
                TextBoxJudul.Text = selectedRow.Cells("Judul").Value?.ToString() ' ?. -> Null conditional operator
                TextBoxPenulis.Text = selectedRow.Cells("Penulis").Value?.ToString()
                TextBoxTahun.Text = selectedRow.Cells("Tahun").Value?.ToString()
                TextBoxKategori.Text = selectedRow.Cells("Kategori").Value?.ToString()

                ' Simpan ID buku yang dipilih untuk proses Edit
                If selectedRow.Cells("ID").Value IsNot Nothing AndAlso IsNumeric(selectedRow.Cells("ID").Value) Then
                    _selectedBookIdForEdit = CInt(selectedRow.Cells("ID").Value)
                    ButtonEditBuku.Enabled = True ' Aktifkan tombol Edit
                Else
                    _selectedBookIdForEdit = Nothing
                    ButtonEditBuku.Enabled = False
                End If

            Catch ex As Exception
                MessageBox.Show("Error saat mengambil data dari baris terpilih: " & ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ClearInputFields()
            End Try
        Else
            ClearInputFields()
        End If
    End Sub

    ' --- Event Handler Tombol Edit & Tambah ---
    Private Sub ButtonEditBuku_Click(sender As Object, e As EventArgs) Handles ButtonEditBuku.Click
        If Not _selectedBookIdForEdit.HasValue Then
            MessageBox.Show("Silakan pilih buku dari daftar yang ingin diedit.", "Edit Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tahun As Integer
        If String.IsNullOrWhiteSpace(TextBoxJudul.Text) OrElse String.IsNullOrWhiteSpace(TextBoxPenulis.Text) OrElse String.IsNullOrWhiteSpace(TextBoxTahun.Text) OrElse String.IsNullOrWhiteSpace(TextBoxKategori.Text) Then
            MessageBox.Show("Semua field (Judul, Penulis, Tahun, Kategori) harus diisi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Integer.TryParse(TextBoxTahun.Text, tahun) OrElse tahun <= 0 Then
            MessageBox.Show("Tahun harus berupa angka positif.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cari baris di DataTable berdasarkan ID
        Dim rowsFound() As DataRow = bookDataTable.Select($"ID = {_selectedBookIdForEdit.Value}")

        If rowsFound.Length > 0 Then
            Dim rowToEdit As DataRow = rowsFound(0) ' Ambil baris pertama (harus unik)

            ' Konfirmasi sebelum edit
            Dim confirmResult = MessageBox.Show($"Anda yakin ingin menyimpan perubahan untuk buku '{rowToEdit("Judul")}' (ID: {_selectedBookIdForEdit.Value})?",
                                               "Konfirmasi Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.No Then Return

            ' Update data di DataTable
            rowToEdit.BeginEdit() ' Mulai mode edit
            rowToEdit("Judul") = TextBoxJudul.Text.Trim()
            rowToEdit("Penulis") = TextBoxPenulis.Text.Trim()
            rowToEdit("Tahun") = tahun
            rowToEdit("Kategori") = TextBoxKategori.Text.Trim()
            ' Status tidak diubah melalui edit ini
            rowToEdit.EndEdit() ' Selesaikan edit

            ' Simpan perubahan dari DataTable ke file CSV
            If SaveChangesToCsv() Then
                MessageBox.Show("Buku berhasil diperbarui.", "Edit Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Refresh grid (otomatis karena DataTable terikat)
                ' Cukup format ulang dan clear
                FormatDataGridView() ' Untuk warna status
                ClearInputFields()
            Else
                MessageBox.Show("Gagal menyimpan perubahan ke file book.csv.", "Error Simpan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Jika gagal, load ulang dari CSV untuk membatalkan perubahan di DataTable
                LoadDataAndRefreshGrid()
            End If
        Else
            MessageBox.Show("Buku yang dipilih untuk diedit tidak ditemukan lagi di data.", "Error Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoadDataAndRefreshGrid() ' Load ulang
            ClearInputFields()
        End If
    End Sub

    Private Sub ButtonTambahBuku_Click(sender As Object, e As EventArgs) Handles ButtonTambahBuku.Click
        Dim tahun As Integer
        If String.IsNullOrWhiteSpace(TextBoxJudul.Text) OrElse String.IsNullOrWhiteSpace(TextBoxPenulis.Text) OrElse String.IsNullOrWhiteSpace(TextBoxTahun.Text) OrElse String.IsNullOrWhiteSpace(TextBoxKategori.Text) Then
            MessageBox.Show("Semua field (Judul, Penulis, Tahun, Kategori) harus diisi untuk menambah buku.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Integer.TryParse(TextBoxTahun.Text, tahun) OrElse tahun <= 0 Then
            MessageBox.Show("Tahun harus berupa angka positif.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Tentukan ID baru (Max ID + 1 dari DataTable)
            Dim newId As Integer = 1
            If bookDataTable.Rows.Count > 0 Then
                ' Gunakan LINQ to DataTable untuk mencari Max ID
                newId = bookDataTable.AsEnumerable().Max(Function(row) row.Field(Of Integer)("ID")) + 1
            End If

            ' Tambahkan baris baru ke DataTable
            bookDataTable.Rows.Add(newId,
                                   TextBoxJudul.Text.Trim(),
                                   TextBoxPenulis.Text.Trim(),
                                   tahun,
                                   TextBoxKategori.Text.Trim(),
                                   "Tersedia") ' Buku baru pasti tersedia

            ' Simpan seluruh DataTable ke file CSV
            If SaveChangesToCsv() Then
                MessageBox.Show("Buku baru berhasil ditambahkan.", "Tambah Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Grid akan update otomatis karena DataSource-nya DataTable
                FormatDataGridView() ' Format ulang warna status
                ClearInputFields()
                TryRestoreSelection(newId) ' Coba pilih baris baru
            Else
                MessageBox.Show("Gagal menyimpan buku baru ke file book.csv.", "Error Simpan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Hapus baris terakhir yang baru ditambahkan jika save gagal
                If bookDataTable.Rows.Count > 0 Then
                    Dim lastRow = bookDataTable.Rows(bookDataTable.Rows.Count - 1)
                    If CInt(lastRow("ID")) = newId Then
                        lastRow.Delete()
                        bookDataTable.AcceptChanges() ' Konfirmasi penghapusan dari DataTable
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menambah buku: " & ex.Message, "Error Tambah", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Fungsi Bantu ---
    Private Sub ClearInputFields()
        TextBoxJudul.Clear()
        TextBoxPenulis.Clear()
        TextBoxTahun.Clear()
        TextBoxKategori.Clear()
        _selectedBookIdForEdit = Nothing
        ButtonEditBuku.Enabled = False
        If Me.Controls.ContainsKey("DataGridViewStatusBuku") AndAlso TypeOf Me.Controls("DataGridViewStatusBuku") Is DataGridView Then
            DirectCast(Me.Controls("DataGridViewStatusBuku"), DataGridView).ClearSelection()
        End If
        TextBoxJudul.Focus()
    End Sub

    ' Fungsi untuk menyimpan DATA TABLE ke book.csv (Overwrite)
    Private Function SaveChangesToCsv() As Boolean
        Dim linesToWrite As New List(Of String)
        ' Header (ambil dari kolom DataTable untuk konsistensi?)
        linesToWrite.Add("id,judul,penulis,tahun,kategori") ' Hardcoded header

        Try
            For Each row As DataRow In bookDataTable.Rows
                Dim fields As New List(Of String)
                ' Ambil data hanya untuk kolom yang sesuai dengan CSV
                ' Gunakan If(Not IsDBNull(...)...) untuk menangani DBNull dan Nothing
                fields.Add(If(Not IsDBNull(row("ID")), row("ID").ToString(), ""))
                fields.Add(QuoteCsvField(If(Not IsDBNull(row("Judul")), row("Judul").ToString(), "")))
                fields.Add(QuoteCsvField(If(Not IsDBNull(row("Penulis")), row("Penulis").ToString(), "")))
                fields.Add(If(Not IsDBNull(row("Tahun")), row("Tahun").ToString(), ""))
                fields.Add(QuoteCsvField(If(Not IsDBNull(row("Kategori")), row("Kategori").ToString(), "")))
                ' Kolom Status TIDAK DISIMPAN ke book.csv
                linesToWrite.Add(String.Join(",", fields))
            Next
            ' --- BATAS BAGIAN YANG DIGANTI ---

            ' Tulis ulang seluruh file
            File.WriteAllLines(bookCsvPath, linesToWrite)
            Return True ' Berhasil

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan perubahan ke file book.csv: " & ex.Message, "Error Penulisan File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Gagal
        End Try
    End Function

    ' Fungsi bantu untuk quoting field CSV (Sama)
    Private Function QuoteCsvField(fieldValue As String) As String
        If String.IsNullOrEmpty(fieldValue) Then Return ""
        If fieldValue.Contains(","c) OrElse fieldValue.Contains(ControlChars.Lf) OrElse fieldValue.Contains(ControlChars.Cr) OrElse fieldValue.Contains(""""c) Then
            Return $"""{fieldValue.Replace("""", """")}"""
        Else
            Return fieldValue
        End If
    End Function

    ' Mencoba memilih kembali baris setelah refresh (Sama)
    Private Sub TryRestoreSelection(bookIdToSelect As Integer?)
        If Not bookIdToSelect.HasValue Then Return
        If Not Me.Controls.ContainsKey("DataGridViewStatusBuku") OrElse Not TypeOf Me.Controls("DataGridViewStatusBuku") Is DataGridView Then Return
        Dim dgv As DataGridView = DirectCast(Me.Controls("DataGridViewStatusBuku"), DataGridView)

        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells("ID").Value IsNot Nothing AndAlso CInt(row.Cells("ID").Value) = bookIdToSelect.Value Then
                row.Selected = True
                If row.Displayed Then
                    dgv.FirstDisplayedScrollingRowIndex = row.Index
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Form3 Then ' Periksa apakah form adalah Form3
                frm.Show() ' Tampilkan lagi Form3
                Exit For   ' Keluar dari loop setelah Form3 ditemukan
            End If
        Next
    End Sub


End Class ' <<<<<< AKHIR DARI CLASS FORM5

'===========================================================
'==> DEFINISI CLASS BOOK dan LOAN TIDAK DIPERLUKAN LAGI JIKA PAKAI DATATABLE <==
'===========================================================
' Public Class Book ... End Class (BISA DIHAPUS/KOMENTARI)
' Public Class Loan ... End Class (BISA DIHAPUS/KOMENTARI)