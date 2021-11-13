<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class readerSearch
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
        Me.Tstp_ADES = New System.Windows.Forms.ToolStrip()
        Me.Tsl_Srch = New System.Windows.Forms.ToolStripLabel()
        Me.TsTb_Srch = New System.Windows.Forms.ToolStripTextBox()
        Me.Tstp_ADES.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tstp_ADES
        '
        Me.Tstp_ADES.BackColor = System.Drawing.Color.Green
        Me.Tstp_ADES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Tstp_ADES.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tstp_ADES.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsl_Srch, Me.TsTb_Srch})
        Me.Tstp_ADES.Location = New System.Drawing.Point(0, 0)
        Me.Tstp_ADES.Name = "Tstp_ADES"
        Me.Tstp_ADES.Size = New System.Drawing.Size(534, 25)
        Me.Tstp_ADES.Stretch = True
        Me.Tstp_ADES.TabIndex = 15
        '
        'Tsl_Srch
        '
        Me.Tsl_Srch.BackColor = System.Drawing.Color.White
        Me.Tsl_Srch.ImageTransparentColor = System.Drawing.Color.White
        Me.Tsl_Srch.Name = "Tsl_Srch"
        Me.Tsl_Srch.Size = New System.Drawing.Size(48, 22)
        Me.Tsl_Srch.Text = "Search :"
        '
        'TsTb_Srch
        '
        Me.TsTb_Srch.BackColor = System.Drawing.Color.White
        Me.TsTb_Srch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TsTb_Srch.Name = "TsTb_Srch"
        Me.TsTb_Srch.Size = New System.Drawing.Size(129, 25)
        '
        'readerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.Tstp_ADES)
        Me.Name = "readerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reader Search"
        Me.Tstp_ADES.ResumeLayout(False)
        Me.Tstp_ADES.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tstp_ADES As ToolStrip
    Friend WithEvents Tsl_Srch As ToolStripLabel
    Friend WithEvents TsTb_Srch As ToolStripTextBox
End Class
