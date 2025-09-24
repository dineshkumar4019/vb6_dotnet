Imports System.Windows.Forms

Public Class Form1
    Inherits Form
    Private WithEvents btn As New Button()
    Public Sub New()
        Me.Text = "VB.NET Legacy Form"
        btn.Text = "Start"
        btn.Left = 20
        btn.Top = 20
        Me.Controls.Add(btn)
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim svc As New LegacyLib.Worker()
        svc.Process("dataset.csv")
        MessageBox.Show("Processing completed.")
    End Sub
End Class
