Module Program

    Public Sub Main(args As String())

        Select Case My.Settings.ModoAvvio
            Case "MDI" : AvviaMdi(args)
        End Select

    End Sub

    Private Sub AvviaMdi(args As String())
        FormMain.IsMdiContainer = True
        Application.Run(FormMain)
    End Sub

    Private Sub Avvia()


        Application.Run(FormMain)
        Application.Run(Form1)
    End Sub

    Private Sub AvviaArgomenti()
        Throw New NotImplementedException()
    End Sub
End Module
