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
        Me.TextBoxTestDisabled = New System.Windows.Forms.TextBox()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonChangeUnderlyingValue = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxTestDisabled
        '
        Me.TextBoxTestDisabled.Enabled = False
        Me.TextBoxTestDisabled.Location = New System.Drawing.Point(32, 34)
        Me.TextBoxTestDisabled.Name = "TextBoxTestDisabled"
        Me.TextBoxTestDisabled.Size = New System.Drawing.Size(187, 22)
        Me.TextBoxTestDisabled.TabIndex = 0
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesc.Location = New System.Drawing.Point(47, 9)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(310, 57)
        Me.LabelDesc.TabIndex = 1
        Me.LabelDesc.Text = "This project checks whether a disabled databound " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textboxes text property can be" &
    " changed by " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "changing the underlying data property"
        Me.LabelDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelDesc.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "databound disabled textbox"
        '
        'ButtonChangeUnderlyingValue
        '
        Me.ButtonChangeUnderlyingValue.Location = New System.Drawing.Point(85, 73)
        Me.ButtonChangeUnderlyingValue.Name = "ButtonChangeUnderlyingValue"
        Me.ButtonChangeUnderlyingValue.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChangeUnderlyingValue.TabIndex = 3
        Me.ButtonChangeUnderlyingValue.Text = "Change Value"
        Me.ButtonChangeUnderlyingValue.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxTestDisabled)
        Me.GroupBox1.Controls.Add(Me.ButtonChangeUnderlyingValue)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 109)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 205)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelDesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTestDisabled As TextBox
    Friend WithEvents LabelDesc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonChangeUnderlyingValue As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
