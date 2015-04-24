<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIAppraisel
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
        Me.Skip = New System.Windows.Forms.Button()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Clear_All_Button = New System.Windows.Forms.Button()
        Me.AppraisleBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Skip
        '
        Me.Skip.Location = New System.Drawing.Point(517, 352)
        Me.Skip.Name = "Skip"
        Me.Skip.Size = New System.Drawing.Size(116, 42)
        Me.Skip.TabIndex = 102
        Me.Skip.Text = "Skip"
        Me.Skip.UseVisualStyleBackColor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(304, 352)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(116, 42)
        Me.Submit_Button.TabIndex = 101
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Clear_All_Button
        '
        Me.Clear_All_Button.Location = New System.Drawing.Point(88, 352)
        Me.Clear_All_Button.Name = "Clear_All_Button"
        Me.Clear_All_Button.Size = New System.Drawing.Size(116, 42)
        Me.Clear_All_Button.TabIndex = 100
        Me.Clear_All_Button.Text = "Clear All"
        Me.Clear_All_Button.UseVisualStyleBackColor = True
        '
        'AppraisleBox
        '
        Me.AppraisleBox.Location = New System.Drawing.Point(61, 29)
        Me.AppraisleBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AppraisleBox.Name = "AppraisleBox"
        Me.AppraisleBox.Size = New System.Drawing.Size(588, 313)
        Me.AppraisleBox.TabIndex = 99
        Me.AppraisleBox.Text = ""
        '
        'PIAppraisel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EVE_Ore_Calculator.My.Resources.Resources.yellow_violet_planet_by_paulinemoss_d532k8u
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(711, 423)
        Me.Controls.Add(Me.Skip)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Clear_All_Button)
        Me.Controls.Add(Me.AppraisleBox)
        Me.Name = "PIAppraisel"
        Me.Text = "PIAppraisel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Skip As System.Windows.Forms.Button
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_All_Button As System.Windows.Forms.Button
    Friend WithEvents AppraisleBox As System.Windows.Forms.RichTextBox
End Class
