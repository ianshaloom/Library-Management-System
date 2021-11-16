<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.manageBtn = New System.Windows.Forms.Button()
        Me.libraryBtn = New System.Windows.Forms.Button()
        Me.reportsBtn = New System.Windows.Forms.Button()
        Me.searchpanel = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SearchBook = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SearchReader = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.librarypanel = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.IssueBook = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ReturnBook = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.managepanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ManageReaders = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ManageBooks = New System.Windows.Forms.Button()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.searchpanel.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.librarypanel.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.managepanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.toolbar.Size = New System.Drawing.Size(1051, 29)
        Me.toolbar.TabIndex = 26
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Dock = System.Windows.Forms.DockStyle.Fill
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(0, 0)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(111, 20)
        Me.length.TabIndex = 27
        Me.length.Text = "MAIN MENU"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(993, 0)
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
        Me.exitt.Location = New System.Drawing.Point(1022, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 29)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.searchBtn)
        Me.Panel1.Controls.Add(Me.manageBtn)
        Me.Panel1.Controls.Add(Me.libraryBtn)
        Me.Panel1.Controls.Add(Me.reportsBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 376)
        Me.Panel1.TabIndex = 27
        '
        'searchBtn
        '
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.White
        Me.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.searchBtn.Location = New System.Drawing.Point(-2, 0)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(269, 93)
        Me.searchBtn.TabIndex = 45
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'manageBtn
        '
        Me.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBtn.ForeColor = System.Drawing.Color.White
        Me.manageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.manageBtn.Location = New System.Drawing.Point(-2, 93)
        Me.manageBtn.Name = "manageBtn"
        Me.manageBtn.Size = New System.Drawing.Size(269, 93)
        Me.manageBtn.TabIndex = 44
        Me.manageBtn.Text = "Manage"
        Me.manageBtn.UseVisualStyleBackColor = True
        '
        'libraryBtn
        '
        Me.libraryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.libraryBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libraryBtn.ForeColor = System.Drawing.Color.White
        Me.libraryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.libraryBtn.Location = New System.Drawing.Point(-2, 186)
        Me.libraryBtn.Name = "libraryBtn"
        Me.libraryBtn.Size = New System.Drawing.Size(269, 93)
        Me.libraryBtn.TabIndex = 43
        Me.libraryBtn.Text = "Library"
        Me.libraryBtn.UseVisualStyleBackColor = True
        '
        'reportsBtn
        '
        Me.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportsBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportsBtn.ForeColor = System.Drawing.Color.White
        Me.reportsBtn.Image = Global.Library_Management_System.My.Resources.Resources.reports
        Me.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reportsBtn.Location = New System.Drawing.Point(-2, 279)
        Me.reportsBtn.Name = "reportsBtn"
        Me.reportsBtn.Size = New System.Drawing.Size(269, 93)
        Me.reportsBtn.TabIndex = 42
        Me.reportsBtn.Text = "Reports"
        Me.reportsBtn.UseVisualStyleBackColor = True
        '
        'searchpanel
        '
        Me.searchpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.searchpanel.Controls.Add(Me.Panel7)
        Me.searchpanel.Controls.Add(Me.Panel6)
        Me.searchpanel.Location = New System.Drawing.Point(331, 32)
        Me.searchpanel.Name = "searchpanel"
        Me.searchpanel.Size = New System.Drawing.Size(656, 366)
        Me.searchpanel.TabIndex = 28
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.SearchBook)
        Me.Panel7.Location = New System.Drawing.Point(90, 91)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(166, 166)
        Me.Panel7.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "SEARCH BOOK"
        '
        'SearchBook
        '
        Me.SearchBook.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.search
        Me.SearchBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBook.Location = New System.Drawing.Point(7, 12)
        Me.SearchBook.Name = "SearchBook"
        Me.SearchBook.Size = New System.Drawing.Size(152, 132)
        Me.SearchBook.TabIndex = 46
        Me.SearchBook.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel6.Controls.Add(Me.SearchReader)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(403, 91)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(166, 166)
        Me.Panel6.TabIndex = 45
        '
        'SearchReader
        '
        Me.SearchReader.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.search
        Me.SearchReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SearchReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchReader.Location = New System.Drawing.Point(7, 6)
        Me.SearchReader.Name = "SearchReader"
        Me.SearchReader.Size = New System.Drawing.Size(152, 132)
        Me.SearchReader.TabIndex = 47
        Me.SearchReader.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "SEARCH READER"
        '
        'librarypanel
        '
        Me.librarypanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.librarypanel.Controls.Add(Me.Panel8)
        Me.librarypanel.Controls.Add(Me.Panel9)
        Me.librarypanel.Location = New System.Drawing.Point(331, 32)
        Me.librarypanel.Name = "librarypanel"
        Me.librarypanel.Size = New System.Drawing.Size(656, 366)
        Me.librarypanel.TabIndex = 39
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel8.Controls.Add(Me.IssueBook)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Location = New System.Drawing.Point(97, 109)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(166, 166)
        Me.Panel8.TabIndex = 46
        '
        'IssueBook
        '
        Me.IssueBook.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.upload
        Me.IssueBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.IssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IssueBook.Location = New System.Drawing.Point(7, 12)
        Me.IssueBook.Name = "IssueBook"
        Me.IssueBook.Size = New System.Drawing.Size(152, 132)
        Me.IssueBook.TabIndex = 46
        Me.IssueBook.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Issue Book"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel9.Controls.Add(Me.ReturnBook)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Location = New System.Drawing.Point(387, 106)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(166, 166)
        Me.Panel9.TabIndex = 47
        '
        'ReturnBook
        '
        Me.ReturnBook.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.download
        Me.ReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBook.Location = New System.Drawing.Point(7, 6)
        Me.ReturnBook.Name = "ReturnBook"
        Me.ReturnBook.Size = New System.Drawing.Size(152, 132)
        Me.ReturnBook.TabIndex = 47
        Me.ReturnBook.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(31, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Return Book"
        '
        'managepanel
        '
        Me.managepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.managepanel.Controls.Add(Me.Panel3)
        Me.managepanel.Controls.Add(Me.Panel2)
        Me.managepanel.Location = New System.Drawing.Point(331, 32)
        Me.managepanel.Name = "managepanel"
        Me.managepanel.Size = New System.Drawing.Size(656, 366)
        Me.managepanel.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ManageReaders)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(396, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(166, 166)
        Me.Panel3.TabIndex = 47
        '
        'ManageReaders
        '
        Me.ManageReaders.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.user
        Me.ManageReaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ManageReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageReaders.Location = New System.Drawing.Point(7, 6)
        Me.ManageReaders.Name = "ManageReaders"
        Me.ManageReaders.Size = New System.Drawing.Size(152, 132)
        Me.ManageReaders.TabIndex = 47
        Me.ManageReaders.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 17)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Manage Readers"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ManageBooks)
        Me.Panel2.Location = New System.Drawing.Point(87, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(166, 166)
        Me.Panel2.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(19, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Manage Books"
        '
        'ManageBooks
        '
        Me.ManageBooks.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.bookshelf
        Me.ManageBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageBooks.Location = New System.Drawing.Point(7, 12)
        Me.ManageBooks.Name = "ManageBooks"
        Me.ManageBooks.Size = New System.Drawing.Size(152, 132)
        Me.ManageBooks.TabIndex = 46
        Me.ManageBooks.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 405)
        Me.Controls.Add(Me.searchpanel)
        Me.Controls.Add(Me.librarypanel)
        Me.Controls.Add(Me.managepanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainMenu"
        Me.Text = "Form1"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.searchpanel.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.librarypanel.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.managepanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolbar As Panel
    Friend WithEvents length As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchpanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents librarypanel As Panel
    Friend WithEvents managepanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents SearchBook As Button
    Friend WithEvents SearchReader As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents IssueBook As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ReturnBook As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ManageReaders As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ManageBooks As Button
    Friend WithEvents searchBtn As Button
    Friend WithEvents manageBtn As Button
    Friend WithEvents libraryBtn As Button
    Friend WithEvents reportsBtn As Button
End Class
