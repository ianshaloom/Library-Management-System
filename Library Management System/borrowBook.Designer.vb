<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class borrowBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(borrowBook))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BkIdCb = New System.Windows.Forms.ComboBox()
        Me.StIdCb = New System.Windows.Forms.ComboBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.IDateCb = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BkNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.length = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IssueDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(436, 488)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 26)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(423, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Books Issued"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BkIdCb)
        Me.Panel1.Controls.Add(Me.StIdCb)
        Me.Panel1.Controls.Add(Me.ResetBtn)
        Me.Panel1.Controls.Add(Me.SubmitBtn)
        Me.Panel1.Controls.Add(Me.EditBtn)
        Me.Panel1.Controls.Add(Me.IDateCb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.StNameTb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BkNameTb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(34, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 134)
        Me.Panel1.TabIndex = 46
        '
        'BkIdCb
        '
        Me.BkIdCb.FormattingEnabled = True
        Me.BkIdCb.Location = New System.Drawing.Point(372, 50)
        Me.BkIdCb.Name = "BkIdCb"
        Me.BkIdCb.Size = New System.Drawing.Size(121, 21)
        Me.BkIdCb.TabIndex = 49
        '
        'StIdCb
        '
        Me.StIdCb.FormattingEnabled = True
        Me.StIdCb.Location = New System.Drawing.Point(56, 48)
        Me.StIdCb.Name = "StIdCb"
        Me.StIdCb.Size = New System.Drawing.Size(121, 21)
        Me.StIdCb.TabIndex = 48
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(525, 93)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(105, 26)
        Me.ResetBtn.TabIndex = 47
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(375, 93)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(105, 26)
        Me.SubmitBtn.TabIndex = 46
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(223, 93)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(105, 26)
        Me.EditBtn.TabIndex = 45
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'IDateCb
        '
        Me.IDateCb.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDateCb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IDateCb.Location = New System.Drawing.Point(732, 45)
        Me.IDateCb.Name = "IDateCb"
        Me.IDateCb.Size = New System.Drawing.Size(98, 24)
        Me.IDateCb.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(368, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Book Id"
        '
        'StNameTb
        '
        Me.StNameTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StNameTb.Enabled = False
        Me.StNameTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StNameTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StNameTb.HintForeColor = System.Drawing.Color.Empty
        Me.StNameTb.HintText = ""
        Me.StNameTb.isPassword = False
        Me.StNameTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.StNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StNameTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.StNameTb.LineThickness = 4
        Me.StNameTb.Location = New System.Drawing.Point(190, 43)
        Me.StNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(167, 27)
        Me.StNameTb.TabIndex = 1
        Me.StNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(189, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Name"
        '
        'BkNameTb
        '
        Me.BkNameTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BkNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BkNameTb.Enabled = False
        Me.BkNameTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BkNameTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BkNameTb.HintForeColor = System.Drawing.Color.Empty
        Me.BkNameTb.HintText = ""
        Me.BkNameTb.isPassword = False
        Me.BkNameTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.BkNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BkNameTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BkNameTb.LineThickness = 4
        Me.BkNameTb.Location = New System.Drawing.Point(532, 42)
        Me.BkNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BkNameTb.Name = "BkNameTb"
        Me.BkNameTb.Size = New System.Drawing.Size(183, 27)
        Me.BkNameTb.TabIndex = 2
        Me.BkNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(531, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Book Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(728, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Issue Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(52, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Student Id"
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Dock = System.Windows.Forms.DockStyle.Fill
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(0, 0)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(103, 20)
        Me.length.TabIndex = 27
        Me.length.Text = "Issue Book"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(932, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitt.Image = Global.Library_Management_System.My.Resources.Resources.exitt
        Me.exitt.Location = New System.Drawing.Point(961, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 29)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
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
        Me.toolbar.Size = New System.Drawing.Size(990, 29)
        Me.toolbar.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(420, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Issue Details"
        '
        'IssueDGV
        '
        Me.IssueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IssueDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.IssueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IssueDGV.Location = New System.Drawing.Point(34, 258)
        Me.IssueDGV.Name = "IssueDGV"
        Me.IssueDGV.Size = New System.Drawing.Size(918, 210)
        Me.IssueDGV.TabIndex = 50
        '
        'borrowBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 521)
        Me.Controls.Add(Me.IssueDGV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "borrowBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "borrowBook"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents BkNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents length As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents toolbar As Panel
    Friend WithEvents IDateCb As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents IssueDGV As DataGridView
    Friend WithEvents BkIdCb As ComboBox
    Friend WithEvents StIdCb As ComboBox
End Class
