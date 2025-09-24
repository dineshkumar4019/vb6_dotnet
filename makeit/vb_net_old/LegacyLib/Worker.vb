Namespace LegacyLib
    Public Class Worker
        Public Sub Process(ByVal filename As String)
            ' Old-style VB.NET processing
            Dim lines() As String = System.IO.File.ReadAllLines(filename)
            For Each l As String In lines
                Debug.WriteLine("Processing: " & l)
            Next
        End Sub
    End Class
End Namespace
