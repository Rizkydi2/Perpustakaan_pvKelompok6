<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkRed
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(561, 347)
        Button4.Name = "Button4"
        Button4.Size = New Size(133, 48)
        Button4.TabIndex = 17
        Button4.Text = "Close"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(356, 347)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 48)
        Button3.TabIndex = 16
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DodgerBlue
        Button2.Location = New Point(434, 263)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 48)
        Button2.TabIndex = 15
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(623, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 31)
        Button1.TabIndex = 23
        Button1.Text = "Show"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(356, 192)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Masukkan Password"
        txtPassword.Size = New Size(337, 31)
        txtPassword.TabIndex = 13
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(356, 100)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Masukkan Username"
        txtUsername.Size = New Size(337, 31)
        txtUsername.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(356, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 11
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(356, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 24)
        Label2.TabIndex = 10
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(479, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 39)
        Label1.TabIndex = 9
        Label1.Text = "Sign Up"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox1.BackgroundImage = My.Resources.Resources.person_80dp_FFFFFF_FILL0_wght400_GRAD0_opsz48
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(-4, -5)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 460)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DodgerBlue
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(57, 275)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 22)
        Label4.TabIndex = 29
        Label4.Text = "Authentication User"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 450)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
