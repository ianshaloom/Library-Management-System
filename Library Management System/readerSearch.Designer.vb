<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class readerSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(readerSearch))
        Me.toolbar = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitt = New System.Windows.Forms.PictureBox()
        Me.BooksDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SearchTb = New Bunifu.Framework.UI.BunifuTextbox()
        Me.toolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.toolbar.Controls.Add(Me.Label5)
        Me.toolbar.Controls.Add(Me.PictureBox1)
        Me.toolbar.Controls.Add(Me.exitt)
        Me.toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(900, 29)
        Me.toolbar.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(212, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Books Search"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.dash
        Me.PictureBox1.Location = New System.Drawing.Point(842, 0)
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
        Me.exitt.Location = New System.Drawing.Point(871, 0)
        Me.exitt.Name = "exitt"
        Me.exitt.Size = New System.Drawing.Size(29, 29)
        Me.exitt.TabIndex = 25
        Me.exitt.TabStop = False
        '
        'BooksDGV
        '
        Me.BooksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BooksDGV.Location = New System.Drawing.Point(216, 51)
        Me.BooksDGV.Name = "BooksDGV"
        Me.BooksDGV.Size = New System.Drawing.Size(676, 338)
        Me.BooksDGV.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BackBtn)
        Me.Panel1.Controls.Add(Me.SearchBtn)
        Me.Panel1.Controls.Add(Me.SearchTb)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 378)
        Me.Panel1.TabIndex = 57
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(44, 334)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(105, 26)
        Me.BackBtn.TabIndex = 56
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'SearchBtn
        '
        Me.SearchBtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SearchBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.BorderRadius = 0
        Me.SearchBtn.ButtonText = "Search Book"
        Me.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBtn.DisabledColor = System.Drawing.Color.Gray
        Me.SearchBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.SearchBtn.Iconimage = CType(resources.GetObject("SearchBtn.Iconimage"), System.Drawing.Image)
        Me.SearchBtn.Iconimage_right = Nothing
        Me.SearchBtn.Iconimage_right_Selected = Nothing
        Me.SearchBtn.Iconimage_Selected = Nothing
        Me.SearchBtn.IconMarginLeft = 0
        Me.SearchBtn.IconMarginRight = 0
        Me.SearchBtn.IconRightVisible = True
        Me.SearchBtn.IconRightZoom = 0R
        Me.SearchBtn.IconVisible = True
        Me.SearchBtn.IconZoom = 90.0R
        Me.SearchBtn.IsTab = False
        Me.SearchBtn.Location = New System.Drawing.Point(12, 70)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.SearchBtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SearchBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.SearchBtn.selected = False
        Me.SearchBtn.Size = New System.Drawing.Size(164, 48)
        Me.SearchBtn.TabIndex = 55
        Me.SearchBtn.Text = "Search Book"
        Me.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SearchBtn.Textcolor = System.Drawing.Color.White
        Me.SearchBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SearchTb
        '
        Me.SearchTb.BackColor = System.Drawing.Color.Silver
        Me.SearchTb.BackgroundImage = CType(resources.GetObject("SearchTb.BackgroundImage"), System.Drawing.Image)
        Me.SearchTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchTb.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.SearchTb.Icon = CType(resources.GetObject("SearchTb.Icon"), System.Drawing.Image)
        Me.SearchTb.Location = New System.Drawing.Point(3, 22)
        Me.SearchTb.Name = "SearchTb"
        Me.SearchTb.Size = New System.Drawing.Size(192, 42)
        Me.SearchTb.TabIndex = 55
        Me.SearchTb.text = ""
        '
        'readerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 407)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.BooksDGV)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "readerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reader Search"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolbar As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitt As PictureBox
    Friend WithEvents BooksDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackBtn As Button
    Friend WithEvents SearchBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SearchTb As Bunifu.Framework.UI.BunifuTextbox
End Class
