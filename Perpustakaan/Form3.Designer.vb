<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Button1 = New Button()
        ButtonEditBuku = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(376, 29)
        Label1.TabIndex = 0
        Label1.Text = "Selamat Datang Kembali User!"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = My.Resources.Resources.borrow1
        Button1.Location = New Point(172, 72)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 128)
        Button1.TabIndex = 1
        Button1.Text = "Peminjaman/Pengembalian"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditBuku
        ' 
        ButtonEditBuku.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonEditBuku.Image = My.Resources.Resources.editorial_design1
        ButtonEditBuku.Location = New Point(404, 72)
        ButtonEditBuku.Margin = New Padding(3, 2, 3, 2)
        ButtonEditBuku.Name = "ButtonEditBuku"
        ButtonEditBuku.Size = New Size(201, 128)
        ButtonEditBuku.TabIndex = 2
        ButtonEditBuku.Text = "Edit Buku"
        ButtonEditBuku.TextAlign = ContentAlignment.BottomCenter
        ButtonEditBuku.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Image = My.Resources.Resources.book1
        Button3.Location = New Point(640, 72)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(201, 128)
        Button3.TabIndex = 3
        Button3.Text = "History Peminjaman"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SteelBlue
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(20, 172)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(95, 28)
        Button4.TabIndex = 4
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(12, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 14)
        Label2.TabIndex = 5
        Label2.Text = "Silahkan Pilih button yang tertera untuk mengakses form selanjutnya"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(177, 218)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(201, 128)
        Button2.TabIndex = 6
        Button2.Text = "Detail Buku"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(878, 357)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ButtonEditBuku)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonEditBuku As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
