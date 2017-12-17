
Public Class Form1
    Private Sub Host_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stub, var1, var2, opt() As String
        Const FileSplit = "|split|"

        FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
        stub = Space(LOF(1))
        FileGet(1, stub)
        FileClose(1)

        opt = Split(stub, FileSplit)
        var1 = opt(1)
        var2 = opt(2)

        LabelVar1.Text = var1
        LabelVar2.Text = var2
    End Sub

End Class

