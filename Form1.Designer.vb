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
        btn_count = New Button()
        SuspendLayout()
        ' 
        ' btn_count
        ' 
        btn_count.Location = New Point(152, 89)
        btn_count.Name = "btn_count"
        btn_count.Size = New Size(131, 40)
        btn_count.TabIndex = 0
        btn_count.Text = "Count"
        btn_count.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 222)
        Controls.Add(btn_count)
        Name = "Form1"
        Text = "Odd and Even"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_count As Button
End Class
