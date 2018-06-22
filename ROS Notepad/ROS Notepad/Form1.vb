Imports System.IO
Imports System.Net
Imports MaterialSkin
Imports Microsoft.VisualBasic.FileIO
Partial Class Form1

    Public WithEvents downloader As WebClient

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Underline)
    End Sub

    Private Sub StrikethroughToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikethroughToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Strikeout)
    End Sub

    Private Sub AlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignCenterToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignRightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
    End Sub

    Private Sub Downloadandset(fileurl As String)
        OpenToolStripMenuItem.Enabled = False
        Dim downloadpath As String = GetTempFolder() & Path.GetRandomFileName & Dialog1.MaterialSingleLineTextField1.Text.Substring(Dialog1.MaterialSingleLineTextField1.Text.Length - 4)
        MaterialProgressBar1.Visible = True
        Try
            downloader = New WebClient
            downloader.DownloadFileAsync(New Uri(fileurl), downloadpath)
            While Not MaterialProgressBar1.Value = 100
                Application.DoEvents()
            End While
            delay(10000)
            If downloadpath.Substring(downloadpath.Length - 4) = ".rtf" Then
                RichTextBox1.LoadFile(downloadpath, RichTextBoxStreamType.RichText)
            Else
                RichTextBox1.LoadFile(downloadpath, RichTextBoxStreamType.PlainText)
            End If
            MaterialProgressBar1.Visible = False
            MaterialProgressBar1.Value = 0
        Catch ex As Exception
            MaterialProgressBar1.Visible = False
            MsgBox("An Error Occurred: " & ex.Message)
        End Try
        OpenToolStripMenuItem.Enabled = True
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        MaterialProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Function GetTempFolder() As String
        Dim folder As String = Path.Combine(Path.GetTempPath, Path.GetRandomFileName)
        Do While Directory.Exists(folder) Or File.Exists(folder)
            folder = Path.Combine(Path.GetTempPath, Path.GetRandomFileName)
        Loop
        Return folder
    End Function

    Private Sub FromWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromWebToolStripMenuItem.Click
        Dialog1.MaterialSingleLineTextField1.Text = Nothing
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = DialogResult.OK Then
            Downloadandset(Dialog1.MaterialSingleLineTextField1.Text)
        End If
    End Sub

    Private Sub delay(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Red200, TextShade.WHITE)
        OpenFileDialog1.InitialDirectory = SpecialDirectories.Desktop
    End Sub

    Private Sub FromFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromFileToolStripMenuItem.Click
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = Nothing Then
            If OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.Length - 4) = ".rtf" Then
                RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
            Else
                RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            End If
        End If
    End Sub
End Class
