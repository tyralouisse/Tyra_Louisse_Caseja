<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.age_txtbox = New System.Windows.Forms.TextBox()
        Me.boton_EVALUATE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'age_txtbox
        '
        Me.age_txtbox.Location = New System.Drawing.Point(103, 50)
        Me.age_txtbox.Name = "age_txtbox"
        Me.age_txtbox.Size = New System.Drawing.Size(260, 20)
        Me.age_txtbox.TabIndex = 0
        '
        'boton_EVALUATE
        '
        Me.boton_EVALUATE.Location = New System.Drawing.Point(175, 144)
        Me.boton_EVALUATE.Name = "boton_EVALUATE"
        Me.boton_EVALUATE.Size = New System.Drawing.Size(107, 32)
        Me.boton_EVALUATE.TabIndex = 1
        Me.boton_EVALUATE.Text = "EVALUATE"
        Me.boton_EVALUATE.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 273)
        Me.Controls.Add(Me.boton_EVALUATE)
        Me.Controls.Add(Me.age_txtbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents age_txtbox As TextBox
    Friend WithEvents boton_EVALUATE As Button
End Class
