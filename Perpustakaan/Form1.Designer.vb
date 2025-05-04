<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        ButtonClose = New Button()
        ButtonSignUp = New Button()
        ButtonLogin = New Button()
        ButtonShowPassword = New Button()
        TextBoxPassword = New TextBox()
        TextBoxUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.DarkRed
        ButtonClose.FlatStyle = FlatStyle.Popup
        ButtonClose.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClose.ForeColor = Color.White
        ButtonClose.Location = New Point(388, 201)
        ButtonClose.Margin = New Padding(2)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(93, 31)
        ButtonClose.TabIndex = 26
        ButtonClose.Text = "Close"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' ButtonSignUp
        ' 
        ButtonSignUp.BackColor = Color.DodgerBlue
        ButtonSignUp.FlatStyle = FlatStyle.Popup
        ButtonSignUp.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSignUp.ForeColor = Color.White
        ButtonSignUp.Location = New Point(244, 201)
        ButtonSignUp.Margin = New Padding(2)
        ButtonSignUp.Name = "ButtonSignUp"
        ButtonSignUp.Size = New Size(140, 31)
        ButtonSignUp.TabIndex = 25
        ButtonSignUp.Text = "Sign Up"
        ButtonSignUp.UseVisualStyleBackColor = False
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.Transparent
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonLogin.ForeColor = Color.DodgerBlue
        ButtonLogin.Location = New Point(297, 149)
        ButtonLogin.Margin = New Padding(2)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(140, 31)
        ButtonLogin.TabIndex = 24
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' ButtonShowPassword
        ' 
        ButtonShowPassword.FlatStyle = FlatStyle.Popup
        ButtonShowPassword.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonShowPassword.Location = New Point(431, 111)
        ButtonShowPassword.Margin = New Padding(2)
        ButtonShowPassword.Name = "ButtonShowPassword"
        ButtonShowPassword.Size = New Size(50, 22)
        ButtonShowPassword.TabIndex = 23
        ButtonShowPassword.Text = "Show"
        ButtonShowPassword.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPassword.Location = New Point(244, 111)
        TextBoxPassword.Margin = New Padding(2)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(237, 22)
        TextBoxPassword.TabIndex = 22
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxUsername.Location = New Point(244, 54)
        TextBoxUsername.Margin = New Padding(2)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(237, 22)
        TextBoxUsername.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(244, 35)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 17)
        Label3.TabIndex = 20
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(244, 93)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 16)
        Label2.TabIndex = 19
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(330, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 25)
        Label1.TabIndex = 18
        Label1.Text = "Sign In"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DodgerBlue
        PictureBox1.BackgroundImage = My.Resources.Resources.person_80dp_FFFFFF_FILL0_wght400_GRAD0_opsz48
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(-4, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(207, 276)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DodgerBlue
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 14)
        Label4.TabIndex = 28
        Label4.Text = "Authentication User"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(560, 270)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(ButtonClose)
        Controls.Add(ButtonSignUp)
        Controls.Add(ButtonLogin)
        Controls.Add(ButtonShowPassword)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonSignUp As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonShowPassword As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
