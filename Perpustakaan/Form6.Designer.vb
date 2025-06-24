<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        ButtonBack = New Button()
        ListViewHistory = New ListView()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonShadow
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(387, 15)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 48)
        Label1.TabIndex = 0
        Label1.Text = "Histori Buku"
        ' 
        ' ButtonBack
        ' 
        ButtonBack.BackColor = Color.SteelBlue
        ButtonBack.FlatStyle = FlatStyle.Popup
        ButtonBack.ForeColor = Color.White
        ButtonBack.Location = New Point(131, 460)
        ButtonBack.Margin = New Padding(4, 5, 4, 5)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(133, 38)
        ButtonBack.TabIndex = 2
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = False
        ' 
        ' ListViewHistory
        ' 
        ListViewHistory.Location = New Point(131, 120)
        ListViewHistory.Margin = New Padding(4, 5, 4, 5)
        ListViewHistory.Name = "ListViewHistory"
        ListViewHistory.Size = New Size(767, 307)
        ListViewHistory.TabIndex = 3
        ListViewHistory.UseCompatibleStateImageBehavior = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonShadow
        PictureBox1.Location = New Point(-7, -2)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1013, 83)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 577)
        Controls.Add(ListViewHistory)
        Controls.Add(ButtonBack)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form6"
        Text = "Form6"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ListViewHistory As ListView
    Friend WithEvents PictureBox1 As PictureBox
End Class
