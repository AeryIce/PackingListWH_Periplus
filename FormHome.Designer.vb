<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
		Me.ButtonTest = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonTest
		'
		Me.ButtonTest.Location = New System.Drawing.Point(363, 215)
		Me.ButtonTest.Name = "ButtonTest"
		Me.ButtonTest.Size = New System.Drawing.Size(75, 23)
		Me.ButtonTest.TabIndex = 0
		Me.ButtonTest.Text = "ButtonTest"
		Me.ButtonTest.UseVisualStyleBackColor = True
		'
		'FormHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.ButtonTest)
		Me.Name = "FormHome"
		Me.Text = "Home"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonTest As Button
End Class
