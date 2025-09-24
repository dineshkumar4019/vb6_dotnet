Option Explicit

Public Sub ProcessData(filename As String)
    Dim s As String
    s = "Processing " & filename
    MsgBox s
    Call Utils_Log(s)
End Sub
