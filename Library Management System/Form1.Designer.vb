<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logIn))
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.passwrd = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.usernamee = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.iconn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.toolbar.SuspendLayout()
        Me.loginpanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.toolbar.Controls.Add(Me.length)
        Me.toolbar.Controls.Add(Me.PictureBox1)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(658, 29)
        Me.toolbar.TabIndex = 25
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(294, 4)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(70, 20)
        Me.length.TabIndex = 27
        Me.length.Text = "LOG IN"
        '
        'loginpanel
        '
        Me.loginpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.loginpanel.Controls.Add(Me.Button1)
        Me.loginpanel.Controls.Add(Me.TextBox2)
        Me.loginpanel.Controls.Add(Me.passwrd)
        Me.loginpanel.Controls.Add(Me.TextBox1)
        Me.loginpanel.Controls.Add(Me.usernamee)
        Me.loginpanel.Location = New System.Drawing.Point(199, 128)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(256, 206)
        Me.loginpanel.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(32, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(32, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(190, 20)
        Me.TextBox2.TabIndex = 6
        '
        'passwrd
        '
        Me.passwrd.AutoSize = True
        Me.passwrd.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwrd.ForeColor = System.Drawing.Color.White
        Me.passwrd.Location = New System.Drawing.Point(75, 82)
        Me.passwrd.Name = "passwrd"
        Me.passwrd.Size = New System.Drawing.Size(91, 20)
        Me.passwrd.TabIndex = 5
        Me.passwrd.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 20)
        Me.TextBox1.TabIndex = 3
        '
        'usernamee
        '
        Me.usernamee.AutoSize = True
        Me.usernamee.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamee.ForeColor = System.Drawing.Color.White
        Me.usernamee.Location = New System.Drawing.Point(75, 4)
        Me.usernamee.Name = "usernamee"
        Me.usernamee.Size = New System.Drawing.Size(97, 20)
        Me.usernamee.TabIndex = 2
        Me.usernamee.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Library_Management_System.My.Resources.Resources.settings
        Me.PictureBox2.Location = New System.Drawing.Point(12, 320)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'iconn
        '
        Me.iconn.Image = CType(resources.GetObject("iconn.Image"), System.Drawing.Image)
        Me.iconn.Location = New System.Drawing.Point(267, 44)
        Me.iconn.Name = "iconn"
        Me.iconn.Size = New System.Drawing.Size(128, 85)
        Me.iconn.TabIndex = 4
        Me.iconn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(597, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Image = Global.Library_Management_System.My.Resources.Resources.exitt
        Me.exitt.Location = New System.Drawing.Point(629, 1)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 28)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'logIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 368)
        Me.Controls.Add(Me.loginpanel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.iconn)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolbar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents loginpanel As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents passwrd As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents usernamee As Label
    Friend WithEvents iconn As PictureBox
    Friend WithEvents length As Label
    Friend WithEvents Button1 As Button
End Class
