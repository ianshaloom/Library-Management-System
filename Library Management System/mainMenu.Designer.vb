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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.length = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.manageBtn = New System.Windows.Forms.Button()
        Me.libraryBtn = New System.Windows.Forms.Button()
        Me.reportsBtn = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.searchpanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.SearchReader = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SearchBook = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.librarypanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.managepanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.userregister = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bookregister = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.incomereport = New Bunifu.Framework.UI.BunifuImageButton()
        Me.duereport = New Bunifu.Framework.UI.BunifuImageButton()
        Me.returnedreport = New Bunifu.Framework.UI.BunifuImageButton()
        Me.issuedreport = New Bunifu.Framework.UI.BunifuImageButton()
        Me.readersreport = New Bunifu.Framework.UI.BunifuImageButton()
        Me.booksreport = New Bunifu.Framework.UI.BunifuImageButton()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        Me.searchpanel.SuspendLayout()
        CType(Me.SearchReader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.librarypanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.managepanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.userregister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.bookregister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incomereport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duereport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnedreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.issuedreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.readersreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.booksreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.Cyan
        Me.toolbar.Controls.Add(Me.length)
        Me.toolbar.Controls.Add(Me.PictureBox1)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(937, 29)
        Me.toolbar.TabIndex = 26
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.Black
        Me.length.Location = New System.Drawing.Point(73, 5)
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
        Me.PictureBox1.Location = New System.Drawing.Point(879, 0)
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
        Me.exitt.Location = New System.Drawing.Point(908, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 29)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'sidepanel
        '
        Me.sidepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sidepanel.Controls.Add(Me.searchBtn)
        Me.sidepanel.Controls.Add(Me.manageBtn)
        Me.sidepanel.Controls.Add(Me.libraryBtn)
        Me.sidepanel.Controls.Add(Me.reportsBtn)
        Me.sidepanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidepanel.Location = New System.Drawing.Point(0, 29)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(269, 376)
        Me.sidepanel.TabIndex = 27
        '
        'searchBtn
        '
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.White
        Me.searchBtn.Image = Global.Library_Management_System.My.Resources.Resources.search_paper
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
        Me.manageBtn.Image = CType(resources.GetObject("manageBtn.Image"), System.Drawing.Image)
        Me.manageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.manageBtn.Location = New System.Drawing.Point(-2, 93)
        Me.manageBtn.Name = "manageBtn"
        Me.manageBtn.Size = New System.Drawing.Size(269, 93)
        Me.manageBtn.TabIndex = 44
        Me.manageBtn.Text = "Register"
        Me.manageBtn.UseVisualStyleBackColor = True
        '
        'libraryBtn
        '
        Me.libraryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.libraryBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libraryBtn.ForeColor = System.Drawing.Color.White
        Me.libraryBtn.Image = Global.Library_Management_System.My.Resources.Resources.bookshelf
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.toolbar
        Me.BunifuDragControl1.Vertical = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(346, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Books Report"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(551, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Readers Report"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(760, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 40)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Issued Books" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Report"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(760, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Income Report"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(551, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 40)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Books Due" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Report"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(346, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 40)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Returned Books" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Report"
        '
        'searchpanel
        '
        Me.searchpanel.BackgroundImage = CType(resources.GetObject("searchpanel.BackgroundImage"), System.Drawing.Image)
        Me.searchpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchpanel.Controls.Add(Me.SearchReader)
        Me.searchpanel.Controls.Add(Me.Label6)
        Me.searchpanel.Controls.Add(Me.SearchBook)
        Me.searchpanel.Controls.Add(Me.Label5)
        Me.searchpanel.GradientBottomLeft = System.Drawing.Color.Cyan
        Me.searchpanel.GradientBottomRight = System.Drawing.Color.Navy
        Me.searchpanel.GradientTopLeft = System.Drawing.Color.Cyan
        Me.searchpanel.GradientTopRight = System.Drawing.Color.Cyan
        Me.searchpanel.Location = New System.Drawing.Point(274, 33)
        Me.searchpanel.Name = "searchpanel"
        Me.searchpanel.Quality = 10
        Me.searchpanel.Size = New System.Drawing.Size(656, 366)
        Me.searchpanel.TabIndex = 46
        '
        'SearchReader
        '
        Me.SearchReader.BackColor = System.Drawing.Color.Transparent
        Me.SearchReader.Image = CType(resources.GetObject("SearchReader.Image"), System.Drawing.Image)
        Me.SearchReader.ImageActive = Nothing
        Me.SearchReader.Location = New System.Drawing.Point(400, 90)
        Me.SearchReader.Name = "SearchReader"
        Me.SearchReader.Size = New System.Drawing.Size(150, 150)
        Me.SearchReader.TabIndex = 48
        Me.SearchReader.TabStop = False
        Me.SearchReader.Zoom = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(413, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Search Reader"
        '
        'SearchBook
        '
        Me.SearchBook.BackColor = System.Drawing.Color.Transparent
        Me.SearchBook.Image = CType(resources.GetObject("SearchBook.Image"), System.Drawing.Image)
        Me.SearchBook.ImageActive = Nothing
        Me.SearchBook.Location = New System.Drawing.Point(90, 90)
        Me.SearchBook.Name = "SearchBook"
        Me.SearchBook.Size = New System.Drawing.Size(150, 150)
        Me.SearchBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchBook.TabIndex = 46
        Me.SearchBook.TabStop = False
        Me.SearchBook.Zoom = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(99, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Search Book"
        '
        'librarypanel
        '
        Me.librarypanel.BackgroundImage = CType(resources.GetObject("librarypanel.BackgroundImage"), System.Drawing.Image)
        Me.librarypanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.librarypanel.Controls.Add(Me.Panel2)
        Me.librarypanel.Controls.Add(Me.Panel3)
        Me.librarypanel.GradientBottomLeft = System.Drawing.Color.Cyan
        Me.librarypanel.GradientBottomRight = System.Drawing.Color.Navy
        Me.librarypanel.GradientTopLeft = System.Drawing.Color.Cyan
        Me.librarypanel.GradientTopRight = System.Drawing.Color.Cyan
        Me.librarypanel.Location = New System.Drawing.Point(274, 33)
        Me.librarypanel.Name = "librarypanel"
        Me.librarypanel.Quality = 10
        Me.librarypanel.Size = New System.Drawing.Size(656, 366)
        Me.librarypanel.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(400, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(166, 188)
        Me.Panel2.TabIndex = 45
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.Library_Management_System.My.Resources.Resources.returnn
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(7, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(150, 150)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 48
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Return Book"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BunifuImageButton2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(90, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(166, 188)
        Me.Panel3.TabIndex = 45
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.Library_Management_System.My.Resources.Resources.issue
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(7, 8)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(150, 150)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 46
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Issue Book"
        '
        'managepanel
        '
        Me.managepanel.BackgroundImage = CType(resources.GetObject("managepanel.BackgroundImage"), System.Drawing.Image)
        Me.managepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.managepanel.Controls.Add(Me.Panel4)
        Me.managepanel.Controls.Add(Me.Panel5)
        Me.managepanel.GradientBottomLeft = System.Drawing.Color.Cyan
        Me.managepanel.GradientBottomRight = System.Drawing.Color.MidnightBlue
        Me.managepanel.GradientTopLeft = System.Drawing.Color.Cyan
        Me.managepanel.GradientTopRight = System.Drawing.Color.Cyan
        Me.managepanel.Location = New System.Drawing.Point(274, 33)
        Me.managepanel.Name = "managepanel"
        Me.managepanel.Quality = 10
        Me.managepanel.Size = New System.Drawing.Size(656, 366)
        Me.managepanel.TabIndex = 47
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.userregister)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(400, 90)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 188)
        Me.Panel4.TabIndex = 45
        '
        'userregister
        '
        Me.userregister.BackColor = System.Drawing.Color.Transparent
        Me.userregister.Image = CType(resources.GetObject("userregister.Image"), System.Drawing.Image)
        Me.userregister.ImageActive = Nothing
        Me.userregister.Location = New System.Drawing.Point(7, 8)
        Me.userregister.Name = "userregister"
        Me.userregister.Size = New System.Drawing.Size(150, 150)
        Me.userregister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userregister.TabIndex = 48
        Me.userregister.TabStop = False
        Me.userregister.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Register Reader"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.bookregister)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(90, 90)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(166, 188)
        Me.Panel5.TabIndex = 45
        '
        'bookregister
        '
        Me.bookregister.BackColor = System.Drawing.Color.Transparent
        Me.bookregister.Image = Global.Library_Management_System.My.Resources.Resources.book
        Me.bookregister.ImageActive = Nothing
        Me.bookregister.Location = New System.Drawing.Point(7, 8)
        Me.bookregister.Name = "bookregister"
        Me.bookregister.Size = New System.Drawing.Size(150, 150)
        Me.bookregister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bookregister.TabIndex = 46
        Me.bookregister.TabStop = False
        Me.bookregister.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Register Book"
        '
        'incomereport
        '
        Me.incomereport.BackColor = System.Drawing.Color.Transparent
        Me.incomereport.Image = Global.Library_Management_System.My.Resources.Resources.report
        Me.incomereport.ImageActive = Nothing
        Me.incomereport.Location = New System.Drawing.Point(761, 235)
        Me.incomereport.Name = "incomereport"
        Me.incomereport.Size = New System.Drawing.Size(96, 96)
        Me.incomereport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.incomereport.TabIndex = 53
        Me.incomereport.TabStop = False
        Me.incomereport.Zoom = 10
        '
        'duereport
        '
        Me.duereport.BackColor = System.Drawing.Color.Transparent
        Me.duereport.Image = Global.Library_Management_System.My.Resources.Resources.report
        Me.duereport.ImageActive = Nothing
        Me.duereport.Location = New System.Drawing.Point(552, 235)
        Me.duereport.Name = "duereport"
        Me.duereport.Size = New System.Drawing.Size(96, 96)
        Me.duereport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duereport.TabIndex = 52
        Me.duereport.TabStop = False
        Me.duereport.Zoom = 10
        '
        'returnedreport
        '
        Me.returnedreport.BackColor = System.Drawing.Color.Transparent
        Me.returnedreport.Image = Global.Library_Management_System.My.Resources.Resources.report
        Me.returnedreport.ImageActive = Nothing
        Me.returnedreport.Location = New System.Drawing.Point(347, 235)
        Me.returnedreport.Name = "returnedreport"
        Me.returnedreport.Size = New System.Drawing.Size(96, 96)
        Me.returnedreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.returnedreport.TabIndex = 51
        Me.returnedreport.TabStop = False
        Me.returnedreport.Zoom = 10
        '
        'issuedreport
        '
        Me.issuedreport.BackColor = System.Drawing.Color.Transparent
        Me.issuedreport.Image = Global.Library_Management_System.My.Resources.Resources.report
        Me.issuedreport.ImageActive = Nothing
        Me.issuedreport.Location = New System.Drawing.Point(763, 63)
        Me.issuedreport.Name = "issuedreport"
        Me.issuedreport.Size = New System.Drawing.Size(96, 96)
        Me.issuedreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.issuedreport.TabIndex = 50
        Me.issuedreport.TabStop = False
        Me.issuedreport.Zoom = 10
        '
        'readersreport
        '
        Me.readersreport.BackColor = System.Drawing.Color.Transparent
        Me.readersreport.Image = Global.Library_Management_System.My.Resources.Resources.report
        Me.readersreport.ImageActive = Nothing
        Me.readersreport.Location = New System.Drawing.Point(554, 63)
        Me.readersreport.Name = "readersreport"
        Me.readersreport.Size = New System.Drawing.Size(96, 96)
        Me.readersreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.readersreport.TabIndex = 49
        Me.readersreport.TabStop = False
        Me.readersreport.Zoom = 10
        '
        'booksreport
        '
        Me.booksreport.BackColor = System.Drawing.Color.Transparent
        Me.booksreport.Image = Global.Library_Management_System.My.Resources.Resources.report
        Me.booksreport.ImageActive = Nothing
        Me.booksreport.Location = New System.Drawing.Point(349, 63)
        Me.booksreport.Name = "booksreport"
        Me.booksreport.Size = New System.Drawing.Size(96, 96)
        Me.booksreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.booksreport.TabIndex = 48
        Me.booksreport.TabStop = False
        Me.booksreport.Zoom = 10
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(937, 405)
        Me.Controls.Add(Me.searchpanel)
        Me.Controls.Add(Me.librarypanel)
        Me.Controls.Add(Me.managepanel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.incomereport)
        Me.Controls.Add(Me.duereport)
        Me.Controls.Add(Me.returnedreport)
        Me.Controls.Add(Me.issuedreport)
        Me.Controls.Add(Me.readersreport)
        Me.Controls.Add(Me.booksreport)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        Me.searchpanel.ResumeLayout(False)
        Me.searchpanel.PerformLayout()
        CType(Me.SearchReader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.librarypanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.managepanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.userregister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.bookregister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incomereport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duereport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnedreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.issuedreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.readersreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.booksreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolbar As Panel
    Friend WithEvents length As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents sidepanel As Panel
    Friend WithEvents searchBtn As Button
    Friend WithEvents manageBtn As Button
    Friend WithEvents libraryBtn As Button
    Friend WithEvents reportsBtn As Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents SearchBook As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SearchReader As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents searchpanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents librarypanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents managepanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents userregister As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents bookregister As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents booksreport As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents readersreport As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents issuedreport As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents incomereport As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents duereport As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents returnedreport As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
