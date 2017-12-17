<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelVar1 = New System.Windows.Forms.Label()
        Me.LabelVar2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Variable 1:"
        '
        'LabelVar1
        '
        Me.LabelVar1.AutoSize = true
        Me.LabelVar1.Location = New System.Drawing.Point(97, 22)
        Me.LabelVar1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVar1.Name = "LabelVar1"
        Me.LabelVar1.Size = New System.Drawing.Size(72, 17)
        Me.LabelVar1.TabIndex = 2
        Me.LabelVar1.Text = "Variable 1"
        '
        'LabelVar2
        '
        Me.LabelVar2.AutoSize = true
        Me.LabelVar2.Location = New System.Drawing.Point(97, 53)
        Me.LabelVar2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVar2.Name = "LabelVar2"
        Me.LabelVar2.Size = New System.Drawing.Size(72, 17)
        Me.LabelVar2.TabIndex = 4
        Me.LabelVar2.Text = "Variable 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(13, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Variable 2:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(201, 101)
        Me.Controls.Add(Me.LabelVar2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelVar1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.Text = "Host"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelVar1 As Label
    Friend WithEvents LabelVar2 As Label
    Friend WithEvents Label4 As Label
End Class
