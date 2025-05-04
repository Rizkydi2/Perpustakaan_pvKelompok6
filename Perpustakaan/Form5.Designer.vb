<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBoxJudul = New TextBox()
        TextBoxKategori = New TextBox()
        TextBoxTahun = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridViewStatusBuku = New DataGridView()
        ButtonEditBuku = New Button()
        ButtonTambahBuku = New Button()
        Label4 = New Label()
        Label5 = New Label()
        TextBoxPenulis = New TextBox()
        Button1 = New Button()
        CType(DataGridViewStatusBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxJudul
        ' 
        TextBoxJudul.Location = New Point(63, 51)
        TextBoxJudul.Margin = New Padding(3, 2, 3, 2)
        TextBoxJudul.Name = "TextBoxJudul"
        TextBoxJudul.Size = New Size(149, 23)
        TextBoxJudul.TabIndex = 0
        ' 
        ' TextBoxKategori
        ' 
        TextBoxKategori.Location = New Point(63, 212)
        TextBoxKategori.Margin = New Padding(3, 2, 3, 2)
        TextBoxKategori.Name = "TextBoxKategori"
        TextBoxKategori.Size = New Size(149, 23)
        TextBoxKategori.TabIndex = 1
        ' 
        ' TextBoxTahun
        ' 
        TextBoxTahun.Location = New Point(63, 104)
        TextBoxTahun.Margin = New Padding(3, 2, 3, 2)
        TextBoxTahun.Name = "TextBoxTahun"
        TextBoxTahun.Size = New Size(149, 23)
        TextBoxTahun.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(63, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 16)
        Label1.TabIndex = 3
        Label1.Text = "Judul "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(63, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 16)
        Label2.TabIndex = 4
        Label2.Text = "Tahun Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(63, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 16)
        Label3.TabIndex = 5
        Label3.Text = "Kategori Buku"
        ' 
        ' DataGridViewStatusBuku
        ' 
        DataGridViewStatusBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewStatusBuku.Location = New Point(276, 35)
        DataGridViewStatusBuku.Margin = New Padding(3, 2, 3, 2)
        DataGridViewStatusBuku.Name = "DataGridViewStatusBuku"
        DataGridViewStatusBuku.RowHeadersWidth = 51
        DataGridViewStatusBuku.Size = New Size(481, 200)
        DataGridViewStatusBuku.TabIndex = 6
        ' 
        ' ButtonEditBuku
        ' 
        ButtonEditBuku.BackColor = Color.DarkSeaGreen
        ButtonEditBuku.FlatStyle = FlatStyle.Popup
        ButtonEditBuku.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonEditBuku.ForeColor = Color.White
        ButtonEditBuku.Location = New Point(12, 268)
        ButtonEditBuku.Margin = New Padding(3, 2, 3, 2)
        ButtonEditBuku.Name = "ButtonEditBuku"
        ButtonEditBuku.Size = New Size(150, 22)
        ButtonEditBuku.TabIndex = 7
        ButtonEditBuku.Text = "Edit Buku"
        ButtonEditBuku.UseVisualStyleBackColor = False
        ' 
        ' ButtonTambahBuku
        ' 
        ButtonTambahBuku.BackColor = SystemColors.HotTrack
        ButtonTambahBuku.FlatStyle = FlatStyle.Popup
        ButtonTambahBuku.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonTambahBuku.ForeColor = Color.White
        ButtonTambahBuku.Location = New Point(168, 268)
        ButtonTambahBuku.Margin = New Padding(3, 2, 3, 2)
        ButtonTambahBuku.Name = "ButtonTambahBuku"
        ButtonTambahBuku.Size = New Size(149, 22)
        ButtonTambahBuku.TabIndex = 8
        ButtonTambahBuku.Text = "Tambah Buku"
        ButtonTambahBuku.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(454, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 18)
        Label4.TabIndex = 9
        Label4.Text = "Status Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(63, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 16)
        Label5.TabIndex = 11
        Label5.Text = "Author"
        ' 
        ' TextBoxPenulis
        ' 
        TextBoxPenulis.Location = New Point(63, 158)
        TextBoxPenulis.Margin = New Padding(3, 2, 3, 2)
        TextBoxPenulis.Name = "TextBoxPenulis"
        TextBoxPenulis.Size = New Size(149, 23)
        TextBoxPenulis.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(682, 268)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 314)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(TextBoxPenulis)
        Controls.Add(Label4)
        Controls.Add(ButtonTambahBuku)
        Controls.Add(ButtonEditBuku)
        Controls.Add(DataGridViewStatusBuku)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxTahun)
        Controls.Add(TextBoxKategori)
        Controls.Add(TextBoxJudul)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridViewStatusBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxJudul As TextBox
    Friend WithEvents TextBoxKategori As TextBox
    Friend WithEvents TextBoxTahun As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewStatusBuku As DataGridView
    Friend WithEvents ButtonEditBuku As Button
    Friend WithEvents ButtonTambahBuku As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPenulis As TextBox
    Friend WithEvents Button1 As Button
End Class
