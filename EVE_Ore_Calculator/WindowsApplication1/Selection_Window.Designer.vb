<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selection_Window
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
        Me.MiningButton = New System.Windows.Forms.Button()
        Me.PIButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MiningButton
        '
        Me.MiningButton.Location = New System.Drawing.Point(24, 51)
        Me.MiningButton.Name = "MiningButton"
        Me.MiningButton.Size = New System.Drawing.Size(118, 59)
        Me.MiningButton.TabIndex = 0
        Me.MiningButton.Text = "Mining"
        Me.MiningButton.UseVisualStyleBackColor = True
        '
        'PIButton
        '
        Me.PIButton.Location = New System.Drawing.Point(215, 51)
        Me.PIButton.Name = "PIButton"
        Me.PIButton.Size = New System.Drawing.Size(118, 59)
        Me.PIButton.TabIndex = 1
        Me.PIButton.Text = "PI"
        Me.PIButton.UseVisualStyleBackColor = True
        '
        'Selection_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 164)
        Me.Controls.Add(Me.PIButton)
        Me.Controls.Add(Me.MiningButton)
        Me.Name = "Selection_Window"
        Me.Text = "Selection_Window"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MiningButton As System.Windows.Forms.Button
    Friend WithEvents PIButton As System.Windows.Forms.Button
End Class
