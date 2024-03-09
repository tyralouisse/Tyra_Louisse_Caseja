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
        Me.math_txt_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.science = New System.Windows.Forms.Label()
        Me.science_txt_box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.english_txt_box = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'math_txt_box
        '
        Me.math_txt_box.Location = New System.Drawing.Point(43, 95)
        Me.math_txt_box.Name = "math_txt_box"
        Me.math_txt_box.Size = New System.Drawing.Size(333, 20)
        Me.math_txt_box.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(40, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GRADE FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MATH"
        '
        'science
        '
        Me.science.AutoSize = True
        Me.science.Location = New System.Drawing.Point(39, 133)
        Me.science.Name = "science"
        Me.science.Size = New System.Drawing.Size(53, 13)
        Me.science.TabIndex = 3
        Me.science.Text = "SCIENCE"
        '
        'science_txt_box
        '
        Me.science_txt_box.Location = New System.Drawing.Point(41, 149)
        Me.science_txt_box.Name = "science_txt_box"
        Me.science_txt_box.Size = New System.Drawing.Size(335, 20)
        Me.science_txt_box.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ENGLISH"
        '
        'english_txt_box
        '
        Me.english_txt_box.Location = New System.Drawing.Point(41, 206)
        Me.english_txt_box.Name = "english_txt_box"
        Me.english_txt_box.Size = New System.Drawing.Size(333, 20)
        Me.english_txt_box.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "EVALUATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 374)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.english_txt_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.science_txt_box)
        Me.Controls.Add(Me.science)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.math_txt_box)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents math_txt_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents science As Label
    Friend WithEvents science_txt_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents english_txt_box As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
