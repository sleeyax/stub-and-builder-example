Public Class Form1
    Const FileSplit As String = "|split|"
    Dim var1, var2, stub As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Executables(.exe) | *.exe"

        If sfd.ShowDialog = DialogResult.OK Then
            var1 = TextBox1.Text
            var2 = TextBox2.Text
        Else
            Exit Sub
        End If

        FileOpen(1, Application.StartupPath & "/Host.exe", OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        stub = Space(LOF(1))
        FileGet(1, stub)
        FileClose(1)

        FileOpen(1, sfd.FileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FilePut(1, stub & FileSplit & var1 & FileSplit & var2 & FileSplit)
        FileClose(1)

        MsgBox("Done! >:)", MsgBoxStyle.OkOnly)

    End Sub
End Class
