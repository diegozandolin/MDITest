Public Class FormMain
    Public ado As String = "123"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f1 As New Form1
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f4 As New Form4

        f4.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Button1_Click(sender, e)
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
