<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(603, 12)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(81, 36)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "Confirm"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(532, 12)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(73, 36)
        Me.MaterialFlatButton2.TabIndex = 1
        Me.MaterialFlatButton2.Text = "Cancel"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "www.thesite.com/theamazingfile.txt"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(12, 18)
        Me.MaterialSingleLineTextField1.MaxLength = 32767
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(513, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 2
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'Dialog1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 55)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.MaterialFlatButton2)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Font = New System.Drawing.Font("Open Sans", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter URL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
