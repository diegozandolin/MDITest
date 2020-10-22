Imports System.ComponentModel

Public Class Form1

    Public mioCampo As String = "Ciao mioCampo" ' Non appare nella PropertyGrid
    Property MiaProprieta As String = "Ciao MiaProprieta" ' Appare nella PropertyGrid
    <Browsable(False)> ' se <Browsable(False)> Non appare nella PropertyGrid
    Property MiaProprieta2 As String = "Ciao MiaProprieta2"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PropertyGrid1.SelectedObject = Me

        Me.Text &= $", MDIParent : {Me.MdiParent.Name}" ' non riesco ad accedere a membri specifici di FormMain come il campo "ado"

        Dim padre = TryCast(Me.MdiParent, FormMain) ' devo sapere a priori il tipo di mio padre, in questo caso "FormMain"
        Me.Text &= $", padre.ado : {padre.ado}" ' ora riesco ad accedere a membri specifici di FormMain come il campo "ado"


    End Sub
End Class