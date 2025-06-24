<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        GroupBox1 = New GroupBox()
        Label15 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label16 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        Label18 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        GroupBox4 = New GroupBox()
        Label17 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox1.BackgroundImage = My.Resources.Resources.stack_of_books
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(-51, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(942, 133)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DodgerBlue
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 50)
        Label1.TabIndex = 1
        Label1.Text = "Waiting List"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DodgerBlue
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(47, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(418, 17)
        Label2.TabIndex = 2
        Label2.Text = "Menampilkan jadwal status peminjaman dan pengembalian buku anda"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(18, 146)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(587, 57)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peminjaman 1 buku"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(225, 30)
        Label15.Name = "Label15"
        Label15.Size = New Size(71, 15)
        Label15.TabIndex = 10
        Label15.Text = "Judul Buku :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(113, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 15)
        Label5.TabIndex = 6
        Label5.Text = "Selesai: 2023-03-10"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 5
        Label4.Text = "Mulai: 2023-03-05"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightSalmon
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(305, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 17)
        Label3.TabIndex = 4
        Label3.Text = "Pending"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(15, 209)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(587, 57)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Peminjaman 2 buku"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(225, 30)
        Label16.Name = "Label16"
        Label16.Size = New Size(71, 15)
        Label16.TabIndex = 11
        Label16.Text = "Judul Buku :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(113, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 15)
        Label6.TabIndex = 6
        Label6.Text = "Selesai: 2023-03-10"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 15)
        Label7.TabIndex = 5
        Label7.Text = "Mulai: 2023-03-05"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.LimeGreen
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(305, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 17)
        Label8.TabIndex = 4
        Label8.Text = "Accept"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Location = New Point(15, 279)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(587, 57)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Peminjaman 3 buku"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(225, 30)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 15)
        Label18.TabIndex = 13
        Label18.Text = "Judul Buku :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(113, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 15)
        Label9.TabIndex = 6
        Label9.Text = "Selesai: 2023-03-10"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 30)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 15)
        Label10.TabIndex = 5
        Label10.Text = "Mulai: 2023-03-05"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.LightCoral
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(302, 28)
        Label11.Name = "Label11"
        Label11.Size = New Size(58, 17)
        Label11.TabIndex = 4
        Label11.Text = "Rejected"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Location = New Point(15, 348)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(587, 57)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "Peminjaman 4 buku"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(225, 30)
        Label17.Name = "Label17"
        Label17.Size = New Size(71, 15)
        Label17.TabIndex = 12
        Label17.Text = "Judul Buku :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(113, 30)
        Label12.Name = "Label12"
        Label12.Size = New Size(106, 15)
        Label12.TabIndex = 6
        Label12.Text = "Selesai: 2023-03-10"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(6, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(101, 15)
        Label13.TabIndex = 5
        Label13.Text = "Mulai: 2023-03-05"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.LightSalmon
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(302, 28)
        Label14.Name = "Label14"
        Label14.Size = New Size(55, 17)
        Label14.TabIndex = 4
        Label14.Text = "Pending"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 449)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form8"
        Text = "Form8"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
End Class
