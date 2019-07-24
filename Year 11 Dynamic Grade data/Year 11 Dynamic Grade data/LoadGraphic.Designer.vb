<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadGraphic
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
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.Load = New System.Windows.Forms.PictureBox()
        CType(Me.Load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.BackColor = System.Drawing.Color.Transparent
        Me.lblmsg.Location = New System.Drawing.Point(12, 9)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(36, 13)
        Me.lblmsg.TabIndex = 0
        Me.lblmsg.Text = "lblmsg"
        '
        'Load
        '
        Me.Load.BackColor = System.Drawing.Color.Transparent
        Me.Load.Image = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.throbber_load_gif
        Me.Load.Location = New System.Drawing.Point(3, 5)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(166, 165)
        Me.Load.TabIndex = 1
        Me.Load.TabStop = False
        '
        'LoadGraphic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Year_11_Dynamic_Grade_data.My.Resources.Resources.gradient
        Me.ClientSize = New System.Drawing.Size(170, 171)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.lblmsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadGraphic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "         "
        CType(Me.Load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents Load As System.Windows.Forms.PictureBox
End Class
