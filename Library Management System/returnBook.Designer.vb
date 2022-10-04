<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(returnBook))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.BkIdCb = New System.Windows.Forms.ComboBox()
        Me.StIdCb = New System.Windows.Forms.ComboBox()
        Me.IssueDate = New System.Windows.Forms.DateTimePicker()
        Me.StNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BkNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FineTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReturnedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IssueDGV = New System.Windows.Forms.DataGridView()
        Me.ReturnDGV = New System.Windows.Forms.DataGridView()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(560, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 23)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Return Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(431, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Book Id"
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.toolbar.Controls.Add(Me.length)
        Me.toolbar.Controls.Add(Me.PictureBox1)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(1320, 36)
        Me.toolbar.TabIndex = 50
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Dock = System.Windows.Forms.DockStyle.Fill
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(0, 0)
        Me.length.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(138, 23)
        Me.length.TabIndex = 27
        Me.length.Text = "Return Book"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(1242, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'exitt
        '
        Me.exitt.BackColor = System.Drawing.Color.Transparent
        Me.exitt.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitt.Image = Global.Library_Management_System.My.Resources.Resources.exitt
        Me.exitt.Location = New System.Drawing.Point(1281, 0)
        Me.exitt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(39, 36)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(179, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(545, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Book Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(800, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Issue Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(55, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Student Id"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(601, 594)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 32)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(795, 290)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 23)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Books Returned"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.CalcBtn)
        Me.Panel1.Controls.Add(Me.ResetBtn)
        Me.Panel1.Controls.Add(Me.BkIdCb)
        Me.Panel1.Controls.Add(Me.StIdCb)
        Me.Panel1.Controls.Add(Me.IssueDate)
        Me.Panel1.Controls.Add(Me.StNameTb)
        Me.Panel1.Controls.Add(Me.BkNameTb)
        Me.Panel1.Controls.Add(Me.FineTb)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ReturnedDate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(45, 98)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1223, 164)
        Me.Panel1.TabIndex = 52
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(401, 107)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(140, 32)
        Me.SaveBtn.TabIndex = 59
        Me.SaveBtn.Text = "Return"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'CalcBtn
        '
        Me.CalcBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcBtn.ForeColor = System.Drawing.Color.White
        Me.CalcBtn.Location = New System.Drawing.Point(1093, 107)
        Me.CalcBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(103, 32)
        Me.CalcBtn.TabIndex = 58
        Me.CalcBtn.Text = "Calculate"
        Me.CalcBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(708, 107)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(140, 32)
        Me.ResetBtn.TabIndex = 57
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'BkIdCb
        '
        Me.BkIdCb.FormattingEnabled = True
        Me.BkIdCb.Location = New System.Drawing.Point(436, 59)
        Me.BkIdCb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BkIdCb.Name = "BkIdCb"
        Me.BkIdCb.Size = New System.Drawing.Size(104, 24)
        Me.BkIdCb.TabIndex = 54
        '
        'StIdCb
        '
        Me.StIdCb.FormattingEnabled = True
        Me.StIdCb.Location = New System.Drawing.Point(60, 62)
        Me.StIdCb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StIdCb.Name = "StIdCb"
        Me.StIdCb.Size = New System.Drawing.Size(113, 24)
        Me.StIdCb.TabIndex = 53
        '
        'IssueDate
        '
        Me.IssueDate.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IssueDate.Location = New System.Drawing.Point(805, 54)
        Me.IssueDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.Size = New System.Drawing.Size(116, 29)
        Me.IssueDate.TabIndex = 52
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
        Me.StNameTb.Location = New System.Drawing.Point(184, 55)
        Me.StNameTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(223, 37)
        Me.StNameTb.TabIndex = 50
        Me.StNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BkNameTb.Location = New System.Drawing.Point(551, 55)
        Me.BkNameTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BkNameTb.Name = "BkNameTb"
        Me.BkNameTb.Size = New System.Drawing.Size(228, 37)
        Me.BkNameTb.TabIndex = 51
        Me.BkNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FineTb
        '
        Me.FineTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FineTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FineTb.Enabled = False
        Me.FineTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FineTb.ForeColor = System.Drawing.Color.Red
        Me.FineTb.HintForeColor = System.Drawing.Color.Empty
        Me.FineTb.HintText = ""
        Me.FineTb.isPassword = False
        Me.FineTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.FineTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FineTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.FineTb.LineThickness = 4
        Me.FineTb.Location = New System.Drawing.Point(1093, 55)
        Me.FineTb.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FineTb.Name = "FineTb"
        Me.FineTb.Size = New System.Drawing.Size(103, 37)
        Me.FineTb.TabIndex = 45
        Me.FineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1105, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 23)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Fine"
        '
        'ReturnedDate
        '
        Me.ReturnedDate.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnedDate.Location = New System.Drawing.Point(936, 55)
        Me.ReturnedDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReturnedDate.Name = "ReturnedDate"
        Me.ReturnedDate.Size = New System.Drawing.Size(113, 29)
        Me.ReturnedDate.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(931, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 23)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Return Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(40, 290)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 23)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Books Issued"
        '
        'IssueDGV
        '
        Me.IssueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IssueDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.IssueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IssueDGV.Location = New System.Drawing.Point(45, 319)
        Me.IssueDGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IssueDGV.Name = "IssueDGV"
        Me.IssueDGV.Size = New System.Drawing.Size(543, 258)
        Me.IssueDGV.TabIndex = 57
        '
        'ReturnDGV
        '
        Me.ReturnDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReturnDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ReturnDGV.Location = New System.Drawing.Point(616, 319)
        Me.ReturnDGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReturnDGV.Name = "ReturnDGV"
        Me.ReturnDGV.Size = New System.Drawing.Size(688, 258)
        Me.ReturnDGV.TabIndex = 58
        '
        'returnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1320, 641)
        Me.Controls.Add(Me.ReturnDGV)
        Me.Controls.Add(Me.IssueDGV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "returnBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "returnBook"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IssueDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents toolbar As Panel
    Friend WithEvents length As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FineTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents ReturnedDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BkIdCb As ComboBox
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents IssueDate As DateTimePicker
    Friend WithEvents StNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BkNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents IssueDGV As DataGridView
    Friend WithEvents ReturnDGV As DataGridView
    Friend WithEvents CalcBtn As Button
    Friend WithEvents SaveBtn As Button
End Class
