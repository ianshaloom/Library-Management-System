<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageReaders
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
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.StNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LABELCOURSE = New System.Windows.Forms.Label()
        Me.CourseTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SemCb = New System.Windows.Forms.ComboBox()
        Me.IdTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.StudentsDGV = New System.Windows.Forms.DataGridView()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StudentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.toolbar.Size = New System.Drawing.Size(990, 29)
        Me.toolbar.TabIndex = 27
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Dock = System.Windows.Forms.DockStyle.Fill
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(0, 0)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(80, 20)
        Me.length.TabIndex = 27
        Me.length.Text = "Readers"
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
        'StNameTb
        '
        Me.StNameTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StNameTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StNameTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StNameTb.HintForeColor = System.Drawing.Color.Empty
        Me.StNameTb.HintText = ""
        Me.StNameTb.isPassword = False
        Me.StNameTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.StNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StNameTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.StNameTb.LineThickness = 4
        Me.StNameTb.Location = New System.Drawing.Point(218, 42)
        Me.StNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(190, 27)
        Me.StNameTb.TabIndex = 1
        Me.StNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(217, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Name"
        '
        'LABELCOURSE
        '
        Me.LABELCOURSE.AutoSize = True
        Me.LABELCOURSE.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABELCOURSE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LABELCOURSE.Location = New System.Drawing.Point(417, 14)
        Me.LABELCOURSE.Name = "LABELCOURSE"
        Me.LABELCOURSE.Size = New System.Drawing.Size(65, 20)
        Me.LABELCOURSE.TabIndex = 31
        Me.LABELCOURSE.Text = "Course"
        '
        'CourseTb
        '
        Me.CourseTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.CourseTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CourseTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CourseTb.HintForeColor = System.Drawing.Color.Empty
        Me.CourseTb.HintText = ""
        Me.CourseTb.isPassword = False
        Me.CourseTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.CourseTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CourseTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.CourseTb.LineThickness = 4
        Me.CourseTb.Location = New System.Drawing.Point(418, 42)
        Me.CourseTb.Margin = New System.Windows.Forms.Padding(4)
        Me.CourseTb.Name = "CourseTb"
        Me.CourseTb.Size = New System.Drawing.Size(142, 27)
        Me.CourseTb.TabIndex = 2
        Me.CourseTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(604, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Year"
        '
        'ContactTb
        '
        Me.ContactTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ContactTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContactTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ContactTb.HintForeColor = System.Drawing.Color.Empty
        Me.ContactTb.HintText = ""
        Me.ContactTb.isPassword = False
        Me.ContactTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.ContactTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ContactTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.ContactTb.LineThickness = 4
        Me.ContactTb.Location = New System.Drawing.Point(727, 42)
        Me.ContactTb.Margin = New System.Windows.Forms.Padding(4)
        Me.ContactTb.Name = "ContactTb"
        Me.ContactTb.Size = New System.Drawing.Size(156, 27)
        Me.ContactTb.TabIndex = 4
        Me.ContactTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(723, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Contact"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SemCb)
        Me.Panel1.Controls.Add(Me.IdTb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ResetBtn)
        Me.Panel1.Controls.Add(Me.DeleteBtn)
        Me.Panel1.Controls.Add(Me.EditBtn)
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.ContactTb)
        Me.Panel1.Controls.Add(Me.StNameTb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CourseTb)
        Me.Panel1.Controls.Add(Me.LABELCOURSE)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(34, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 134)
        Me.Panel1.TabIndex = 40
        '
        'SemCb
        '
        Me.SemCb.FormattingEnabled = True
        Me.SemCb.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.SemCb.Location = New System.Drawing.Point(608, 48)
        Me.SemCb.Name = "SemCb"
        Me.SemCb.Size = New System.Drawing.Size(45, 21)
        Me.SemCb.TabIndex = 47
        '
        'IdTb
        '
        Me.IdTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.IdTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdTb.HintForeColor = System.Drawing.Color.Empty
        Me.IdTb.HintText = ""
        Me.IdTb.isPassword = False
        Me.IdTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.IdTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IdTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.IdTb.LineThickness = 4
        Me.IdTb.Location = New System.Drawing.Point(86, 42)
        Me.IdTb.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTb.Name = "IdTb"
        Me.IdTb.Size = New System.Drawing.Size(92, 27)
        Me.IdTb.TabIndex = 45
        Me.IdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(85, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Student ID"
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(643, 94)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(105, 26)
        Me.ResetBtn.TabIndex = 43
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(493, 94)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(105, 26)
        Me.DeleteBtn.TabIndex = 42
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(341, 94)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(105, 26)
        Me.EditBtn.TabIndex = 41
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(177, 94)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(105, 26)
        Me.SaveBtn.TabIndex = 40
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(409, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Readers Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(423, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Readers List"
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(436, 482)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(105, 26)
        Me.BackBtn.TabIndex = 40
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'StudentsDGV
        '
        Me.StudentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentsDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StudentsDGV.Location = New System.Drawing.Point(34, 255)
        Me.StudentsDGV.Name = "StudentsDGV"
        Me.StudentsDGV.Size = New System.Drawing.Size(918, 210)
        Me.StudentsDGV.TabIndex = 48
        '
        'manageReaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 521)
        Me.Controls.Add(Me.StudentsDGV)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageReaders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageReaders"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StudentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolbar As Panel
    Friend WithEvents length As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents StNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents LABELCOURSE As Label
    Friend WithEvents CourseTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents StudentsDGV As DataGridView
    Friend WithEvents ResetBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents IdTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents SemCb As ComboBox
End Class
