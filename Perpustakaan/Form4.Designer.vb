<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        ButtonPinjam = New Button()
        TextBoxNamaPeminjam = New TextBox()
        ListView1 = New ListView()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxJudulPinjam = New TextBox()
        TextBoxJudulKembali = New TextBox()
        Label4 = New Label()
        ListView2 = New ListView()
        ButtonKembalikan = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ButtonPinjam
        ' 
        ButtonPinjam.BackColor = Color.LimeGreen
        ButtonPinjam.FlatStyle = FlatStyle.Popup
        ButtonPinjam.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonPinjam.ForeColor = Color.White
        ButtonPinjam.Location = New Point(560, 78)
        ButtonPinjam.Name = "ButtonPinjam"
        ButtonPinjam.Size = New Size(84, 23)
        ButtonPinjam.TabIndex = 0
        ButtonPinjam.Text = "Pinjam"
        ButtonPinjam.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNamaPeminjam
        ' 
        TextBoxNamaPeminjam.Location = New Point(154, 79)
        TextBoxNamaPeminjam.Name = "TextBoxNamaPeminjam"
        TextBoxNamaPeminjam.Size = New Size(124, 23)
        TextBoxNamaPeminjam.TabIndex = 2
        ' 
        ' ListView1
        ' 
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(154, 118)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(481, 97)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(154, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 14)
        Label2.TabIndex = 4
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(454, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 14)
        Label3.TabIndex = 5
        Label3.Text = "Judul"
        ' 
        ' TextBoxJudulPinjam
        ' 
        TextBoxJudulPinjam.Location = New Point(454, 79)
        TextBoxJudulPinjam.Name = "TextBoxJudulPinjam"
        TextBoxJudulPinjam.Size = New Size(100, 23)
        TextBoxJudulPinjam.TabIndex = 6
        ' 
        ' TextBoxJudulKembali
        ' 
        TextBoxJudulKembali.Location = New Point(454, 292)
        TextBoxJudulKembali.Name = "TextBoxJudulKembali"
        TextBoxJudulKembali.Size = New Size(100, 23)
        TextBoxJudulKembali.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(454, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 14)
        Label4.TabIndex = 12
        Label4.Text = "Judul"
        ' 
        ' ListView2
        ' 
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Location = New Point(154, 322)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(481, 84)
        ListView2.TabIndex = 10
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' ButtonKembalikan
        ' 
        ButtonKembalikan.BackColor = Color.LimeGreen
        ButtonKembalikan.FlatStyle = FlatStyle.Popup
        ButtonKembalikan.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonKembalikan.ForeColor = Color.White
        ButtonKembalikan.Location = New Point(560, 292)
        ButtonKembalikan.Name = "ButtonKembalikan"
        ButtonKembalikan.Size = New Size(84, 24)
        ButtonKembalikan.TabIndex = 7
        ButtonKembalikan.Text = "Kembalikan"
        ButtonKembalikan.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkRed
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(679, 410)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(317, 11)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 27)
        Label5.TabIndex = 19
        Label5.Text = "Peminjaman Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(317, 236)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 25)
        Label1.TabIndex = 20
        Label1.Text = "Pengembalian Buku" & vbCrLf
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 474)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(TextBoxJudulKembali)
        Controls.Add(Label4)
        Controls.Add(ListView2)
        Controls.Add(ButtonKembalikan)
        Controls.Add(TextBoxJudulPinjam)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(TextBoxNamaPeminjam)
        Controls.Add(ButtonPinjam)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonPinjam As Button
    Friend WithEvents TextBoxNamaPeminjam As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxJudulPinjam As TextBox
    Friend WithEvents TextBoxJudulKembali As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ButtonKembalikan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
