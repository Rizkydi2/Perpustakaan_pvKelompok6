<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label9 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox1.BackgroundImage = My.Resources.Resources.ratings
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(-1, -5)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(734, 242)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DodgerBlue
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(254, 136)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 48)
        Label1.TabIndex = 1
        Label1.Text = "Rating Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DodgerBlue
        Label2.Location = New Point(160, 184)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(427, 25)
        Label2.TabIndex = 2
        Label2.Text = "Berikan Penilaian dan ulasan untuk buku favorit anda"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(53, 303)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Masukkan judul buku"
        TextBox1.Size = New Size(251, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(429, 303)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Nama Penulis buku . . ."
        TextBox2.Size = New Size(250, 31)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(53, 407)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Tahun buku . . ."
        TextBox3.Size = New Size(251, 31)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(429, 407)
        TextBox4.Margin = New Padding(4, 5, 4, 5)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Kategori buku . . ."
        TextBox4.Size = New Size(250, 31)
        TextBox4.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 267)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 7
        Label3.Text = "Judul Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(429, 267)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 25)
        Label4.TabIndex = 8
        Label4.Text = "Penulis Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(54, 377)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 9
        Label5.Text = "Tahun Buku"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(429, 377)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 25)
        Label6.TabIndex = 10
        Label6.Text = "Kategori Buku"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(306, 463)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 25)
        Label7.TabIndex = 11
        Label7.Text = "Rating Buku *"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.BackgroundImage = My.Resources.Resources.star
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(262, 507)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(33, 37)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.OrangeRed
        Label8.Location = New Point(469, 513)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 25)
        Label8.TabIndex = 17
        Label8.Text = "Pilih Rating"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(53, 600)
        TextBox5.Margin = New Padding(4, 5, 4, 5)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Tulis ulasan anda tentang buku ini . . ."
        TextBox5.Size = New Size(621, 156)
        TextBox5.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(54, 570)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(123, 25)
        Label9.TabIndex = 19
        Label9.Text = "Ulasan Review"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.BackgroundImage = My.Resources.Resources.star
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(428, 507)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(33, 37)
        Button2.TabIndex = 20
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DimGray
        Button3.BackgroundImage = My.Resources.Resources.star
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(387, 507)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(33, 37)
        Button3.TabIndex = 21
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DimGray
        Button4.BackgroundImage = My.Resources.Resources.star
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Location = New Point(344, 507)
        Button4.Margin = New Padding(4, 5, 4, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(33, 37)
        Button4.TabIndex = 22
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DimGray
        Button5.BackgroundImage = My.Resources.Resources.star
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Location = New Point(303, 507)
        Button5.Margin = New Padding(4, 5, 4, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(33, 37)
        Button5.TabIndex = 23
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(731, 795)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form10"
        Text = "Form10"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
