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
        Me.BooksDGV = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BQuantityTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BPublisherTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BPriceTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.BNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.BAuthorTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.BooksDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BooksDGV
        '
        Me.BooksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BooksDGV.Location = New System.Drawing.Point(90, 239)
        Me.BooksDGV.Name = "BooksDGV"
        Me.BooksDGV.Size = New System.Drawing.Size(918, 210)
        Me.BooksDGV.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(479, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Books List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(465, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Books Details"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BQuantityTb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BPublisherTb)
        Me.Panel1.Controls.Add(Me.BPriceTb)
        Me.Panel1.Controls.Add(Me.ResetBtn)
        Me.Panel1.Controls.Add(Me.BNameTb)
        Me.Panel1.Controls.Add(Me.DeleteBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EditBtn)
        Me.Panel1.Controls.Add(Me.BAuthorTb)
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(90, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 134)
        Me.Panel1.TabIndex = 49
        '
        'BQuantityTb
        '
        Me.BQuantityTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BQuantityTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BQuantityTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BQuantityTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BQuantityTb.HintForeColor = System.Drawing.Color.Empty
        Me.BQuantityTb.HintText = ""
        Me.BQuantityTb.isPassword = False
        Me.BQuantityTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.BQuantityTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BQuantityTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BQuantityTb.LineThickness = 4
        Me.BQuantityTb.Location = New System.Drawing.Point(811, 42)
        Me.BQuantityTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BQuantityTb.Name = "BQuantityTb"
        Me.BQuantityTb.Size = New System.Drawing.Size(83, 27)
        Me.BQuantityTb.TabIndex = 5
        Me.BQuantityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(807, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Quantity"
        '
        'BPublisherTb
        '
        Me.BPublisherTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BPublisherTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BPublisherTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPublisherTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BPublisherTb.HintForeColor = System.Drawing.Color.Empty
        Me.BPublisherTb.HintText = ""
        Me.BPublisherTb.isPassword = False
        Me.BPublisherTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.BPublisherTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BPublisherTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BPublisherTb.LineThickness = 4
        Me.BPublisherTb.Location = New System.Drawing.Point(440, 42)
        Me.BPublisherTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BPublisherTb.Name = "BPublisherTb"
        Me.BPublisherTb.Size = New System.Drawing.Size(119, 27)
        Me.BPublisherTb.TabIndex = 3
        Me.BPublisherTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BPriceTb
        '
        Me.BPriceTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BPriceTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPriceTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BPriceTb.HintForeColor = System.Drawing.Color.Empty
        Me.BPriceTb.HintText = ""
        Me.BPriceTb.isPassword = False
        Me.BPriceTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.BPriceTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BPriceTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BPriceTb.LineThickness = 4
        Me.BPriceTb.Location = New System.Drawing.Point(697, 42)
        Me.BPriceTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BPriceTb.Name = "BPriceTb"
        Me.BPriceTb.Size = New System.Drawing.Size(83, 27)
        Me.BPriceTb.TabIndex = 4
        Me.BPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(626, 92)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(105, 26)
        Me.ResetBtn.TabIndex = 39
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'BNameTb
        '
        Me.BNameTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BNameTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNameTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BNameTb.HintForeColor = System.Drawing.Color.Empty
        Me.BNameTb.HintText = ""
        Me.BNameTb.isPassword = False
        Me.BNameTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.BNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BNameTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BNameTb.LineThickness = 4
        Me.BNameTb.Location = New System.Drawing.Point(119, 42)
        Me.BNameTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BNameTb.Name = "BNameTb"
        Me.BNameTb.Size = New System.Drawing.Size(156, 27)
        Me.BNameTb.TabIndex = 1
        Me.BNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(476, 92)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(105, 26)
        Me.DeleteBtn.TabIndex = 38
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(115, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Book Name"
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(324, 92)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(105, 26)
        Me.EditBtn.TabIndex = 37
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'BAuthorTb
        '
        Me.BAuthorTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BAuthorTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BAuthorTb.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAuthorTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BAuthorTb.HintForeColor = System.Drawing.Color.Empty
        Me.BAuthorTb.HintText = ""
        Me.BAuthorTb.isPassword = False
        Me.BAuthorTb.LineFocusedColor = System.Drawing.Color.Blue
        Me.BAuthorTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAuthorTb.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BAuthorTb.LineThickness = 4
        Me.BAuthorTb.Location = New System.Drawing.Point(299, 42)
        Me.BAuthorTb.Margin = New System.Windows.Forms.Padding(4)
        Me.BAuthorTb.Name = "BAuthorTb"
        Me.BAuthorTb.Size = New System.Drawing.Size(125, 27)
        Me.BAuthorTb.TabIndex = 2
        Me.BAuthorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(160, 92)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(105, 26)
        Me.SaveBtn.TabIndex = 6
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(295, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(693, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(436, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Publisher"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1098, 465)
        Me.Controls.Add(Me.BooksDGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BooksDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooksDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BQuantityTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents BPublisherTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BPriceTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents BNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents BAuthorTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
