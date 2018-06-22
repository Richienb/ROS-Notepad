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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrikethroughToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignJustifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialProgressBar1 = New MaterialSkin.Controls.MaterialProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Open Sans", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ClipboardToolStripMenuItem, Me.FontToolStripMenuItem, Me.AlignToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.PrintToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.SendToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(49, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.file
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FromFileToolStripMenuItem, Me.FromWebToolStripMenuItem})
        Me.OpenToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.open
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'FromFileToolStripMenuItem
        '
        Me.FromFileToolStripMenuItem.Name = "FromFileToolStripMenuItem"
        Me.FromFileToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.FromFileToolStripMenuItem.Text = "From Computer"
        '
        'FromWebToolStripMenuItem
        '
        Me.FromWebToolStripMenuItem.Name = "FromWebToolStripMenuItem"
        Me.FromWebToolStripMenuItem.Size = New System.Drawing.Size(206, 28)
        Me.FromWebToolStripMenuItem.Text = "From Internet"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.save_as
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.print
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'SendToolStripMenuItem
        '
        Me.SendToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.send
        Me.SendToolStripMenuItem.Name = "SendToolStripMenuItem"
        Me.SendToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.SendToolStripMenuItem.Text = "Send"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.info
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.delete
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(51, 27)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.undo
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.redo
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ClipboardToolStripMenuItem
        '
        Me.ClipboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ClipboardToolStripMenuItem.Name = "ClipboardToolStripMenuItem"
        Me.ClipboardToolStripMenuItem.Size = New System.Drawing.Size(97, 27)
        Me.ClipboardToolStripMenuItem.Text = "Clipboard"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.cut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.select_all
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem1, Me.BoldToolStripMenuItem, Me.ItalicToolStripMenuItem, Me.UnderlineToolStripMenuItem, Me.StrikethroughToolStripMenuItem})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(79, 27)
        Me.FontToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(187, 28)
        Me.FontToolStripMenuItem1.Text = "Font"
        '
        'BoldToolStripMenuItem
        '
        Me.BoldToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.bold
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'ItalicToolStripMenuItem
        '
        Me.ItalicToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.italic
        Me.ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem"
        Me.ItalicToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.ItalicToolStripMenuItem.Text = "Italic"
        '
        'UnderlineToolStripMenuItem
        '
        Me.UnderlineToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.underline
        Me.UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem"
        Me.UnderlineToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.UnderlineToolStripMenuItem.Text = "Underline"
        '
        'StrikethroughToolStripMenuItem
        '
        Me.StrikethroughToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.strikethrough
        Me.StrikethroughToolStripMenuItem.Name = "StrikethroughToolStripMenuItem"
        Me.StrikethroughToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.StrikethroughToolStripMenuItem.Text = "Strikethrough"
        '
        'AlignToolStripMenuItem
        '
        Me.AlignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlightToolStripMenuItem, Me.AlignCenterToolStripMenuItem, Me.AlignRightToolStripMenuItem, Me.AlignJustifyToolStripMenuItem})
        Me.AlignToolStripMenuItem.Name = "AlignToolStripMenuItem"
        Me.AlignToolStripMenuItem.Size = New System.Drawing.Size(60, 27)
        Me.AlignToolStripMenuItem.Text = "Align"
        '
        'AlightToolStripMenuItem
        '
        Me.AlightToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.align_left
        Me.AlightToolStripMenuItem.Name = "AlightToolStripMenuItem"
        Me.AlightToolStripMenuItem.Size = New System.Drawing.Size(134, 28)
        Me.AlightToolStripMenuItem.Text = "Left"
        '
        'AlignCenterToolStripMenuItem
        '
        Me.AlignCenterToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.align_center
        Me.AlignCenterToolStripMenuItem.Name = "AlignCenterToolStripMenuItem"
        Me.AlignCenterToolStripMenuItem.Size = New System.Drawing.Size(134, 28)
        Me.AlignCenterToolStripMenuItem.Text = "Center"
        '
        'AlignRightToolStripMenuItem
        '
        Me.AlignRightToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.align_right
        Me.AlignRightToolStripMenuItem.Name = "AlignRightToolStripMenuItem"
        Me.AlignRightToolStripMenuItem.Size = New System.Drawing.Size(134, 28)
        Me.AlignRightToolStripMenuItem.Text = "Right"
        '
        'AlignJustifyToolStripMenuItem
        '
        Me.AlignJustifyToolStripMenuItem.Image = Global.ROS_Notepad.My.Resources.Resources.align_justify
        Me.AlignJustifyToolStripMenuItem.Name = "AlignJustifyToolStripMenuItem"
        Me.AlignJustifyToolStripMenuItem.Size = New System.Drawing.Size(134, 28)
        Me.AlignJustifyToolStripMenuItem.Text = "Justify"
        '
        'MaterialProgressBar1
        '
        Me.MaterialProgressBar1.Depth = 0
        Me.MaterialProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialProgressBar1.Location = New System.Drawing.Point(0, 525)
        Me.MaterialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialProgressBar1.Name = "MaterialProgressBar1"
        Me.MaterialProgressBar1.Size = New System.Drawing.Size(734, 5)
        Me.MaterialProgressBar1.TabIndex = 2
        Me.MaterialProgressBar1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(734, 492)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New File"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(720, 450)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'ColorDialog1
        '
        Me.ColorDialog1.SolidColorOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.Filter = "Supported Files|*.txt;*.rtf|Plain Text Files|*.txt|Rich Text Files|*.rtf|All File" &
    "s|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 530)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MaterialProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Open Sans", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.Text = "ROS Notepad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItalicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnderlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StrikethroughToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialProgressBar1 As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignCenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignJustifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
