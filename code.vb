Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub runhtml_Click(sender As Object, e As EventArgs) Handles runhtml.Click
        Form2.Show()
        Form2.WebBrowser1.DocumentText = textbox.Text

    End Sub
    Private Sub credits_Click(sender As Object, e As EventArgs) Handles credits.Click
        MsgBox("HtmlEdit v0.1 - Made by Pufflegamerz")
    End Sub
    Private Sub saveas_Click(sender As Object, e As EventArgs) Handles saveas.Click
        savedialog.ShowDialog()
        My.Computer.FileSystem.WriteAllText(savedialog.FileName, textbox.Text, False)
        Me.Text = Me.Text + " - " + savedialog.FileName
    End Sub
    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        opendialog.ShowDialog()
        Me.Text = Me.Text + " - " + opendialog.FileName
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(opendialog.FileName)
        textbox.Text = fileReader
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim currentfile As String
        currentfile = Me.Text.Replace("HtmlEdit - ", "")
        My.Computer.FileSystem.WriteAllText(currentfile, textbox.Text, False)
    End Sub
End Class
