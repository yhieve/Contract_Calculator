<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiningAppraisel
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
        Me.AppraisleBox = New System.Windows.Forms.RichTextBox()
        Me.Skip = New System.Windows.Forms.Button()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Clear_All_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AppraisleBox
        '
        Me.AppraisleBox.Location = New System.Drawing.Point(60, 29)
        Me.AppraisleBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AppraisleBox.Name = "AppraisleBox"
        Me.AppraisleBox.Size = New System.Drawing.Size(588, 313)
        Me.AppraisleBox.TabIndex = 99
        Me.AppraisleBox.Text = ""
        '
        'Skip
        '
        Me.Skip.Location = New System.Drawing.Point(500, 369)
        Me.Skip.Name = "Skip"
        Me.Skip.Size = New System.Drawing.Size(116, 42)
        Me.Skip.TabIndex = 104
        Me.Skip.Text = "Skip"
        Me.Skip.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(297, 369)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(116, 42)
        Me.Submit_Button.TabIndex = 103
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Clear_All_Button
        '
        Me.Clear_All_Button.Location = New System.Drawing.Point(95, 369)
        Me.Clear_All_Button.Name = "Clear_All_Button"
        Me.Clear_All_Button.Size = New System.Drawing.Size(116, 42)
        Me.Clear_All_Button.TabIndex = 102
        Me.Clear_All_Button.Text = "Clear All"
        Me.Clear_All_Button.UseVisualStyleBackColor = True
        '
        'MiningAppraisel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EVE_Ore_Calculator.My.Resources.Resources.NASA_Asteroid_Mining
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(711, 423)
        Me.Controls.Add(Me.Skip)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Clear_All_Button)
        Me.Controls.Add(Me.AppraisleBox)
        Me.Name = "MiningAppraisel"
        Me.Text = "MiningAppraisel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AppraisleBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Skip As System.Windows.Forms.Button
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_All_Button As System.Windows.Forms.Button
End Class
