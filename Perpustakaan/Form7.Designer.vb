<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        ComboBoxJudul = New ComboBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        LabelPenulis = New Label()
        GroupBox3 = New GroupBox()
        LabelTahun = New Label()
        GroupBox4 = New GroupBox()
        LabelKategori = New Label()
        GroupBox5 = New GroupBox()
        Label9 = New Label()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(27, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 181)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(27, 214)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 37)
        Button1.TabIndex = 1
        Button1.Text = "Pinjam Buku"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Blue
        Button3.Location = New Point(27, 269)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 35)
        Button3.TabIndex = 4
        Button3.Text = "Tambah ke Wishlist"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(228, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 37)
        Label1.TabIndex = 3
        Label1.Text = "Contoh Nama Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(228, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 17)
        Label2.TabIndex = 5
        Label2.Text = "Oleh Contoh Penulis Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(241, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBoxJudul)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(241, 123)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(252, 61)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Judul"
        ' 
        ' ComboBoxJudul
        ' 
        ComboBoxJudul.FormattingEnabled = True
        ComboBoxJudul.Location = New Point(20, 22)
        ComboBoxJudul.Name = "ComboBoxJudul"
        ComboBoxJudul.Size = New Size(226, 23)
        ComboBoxJudul.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(LabelPenulis)
        GroupBox2.Location = New Point(241, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(252, 61)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Penulis"
        ' 
        ' LabelPenulis
        ' 
        LabelPenulis.AutoSize = True
        LabelPenulis.Location = New Point(20, 31)
        LabelPenulis.Name = "LabelPenulis"
        LabelPenulis.Size = New Size(88, 15)
        LabelPenulis.TabIndex = 1
        LabelPenulis.Text = "Contoh Penulis"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(LabelTahun)
        GroupBox3.Location = New Point(241, 287)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(252, 61)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Tahun"
        ' 
        ' LabelTahun
        ' 
        LabelTahun.AutoSize = True
        LabelTahun.Location = New Point(20, 30)
        LabelTahun.Name = "LabelTahun"
        LabelTahun.Size = New Size(83, 15)
        LabelTahun.TabIndex = 2
        LabelTahun.Text = "Contoh Tahun"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(LabelKategori)
        GroupBox4.Location = New Point(241, 371)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(252, 61)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Kategori"
        ' 
        ' LabelKategori
        ' 
        LabelKategori.AutoSize = True
        LabelKategori.Location = New Point(20, 31)
        LabelKategori.Name = "LabelKategori"
        LabelKategori.Size = New Size(94, 15)
        LabelKategori.TabIndex = 3
        LabelKategori.Text = "Contoh Kategori"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label9)
        GroupBox5.Location = New Point(241, 461)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(252, 61)
        GroupBox5.TabIndex = 11
        GroupBox5.TabStop = False
        GroupBox5.Text = "Status"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(20, 34)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 15)
        Label9.TabIndex = 4
        Label9.Text = "Contoh Status"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.DimGray
        LinkLabel1.Location = New Point(238, 78)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(111, 17)
        LinkLabel1.TabIndex = 12
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "4.2/5 (128 ulasan)"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(546, 449)
        Controls.Add(LinkLabel1)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form7"
        Text = "Form7"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelPenulis As Label
    Friend WithEvents LabelTahun As Label
    Friend WithEvents LabelKategori As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComboBoxJudul As ComboBox
End Class
