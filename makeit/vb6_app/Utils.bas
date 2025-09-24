Option Explicit

Public Sub Utils_Log(msg As String)
    ' Very old-school logging to a text file
    Dim fnum As Integer
    fnum = FreeFile
    Open App.Path & "\legacy.log" For Append As #fnum
    Print #fnum, Now & " - " & msg
    Close #fnum
End Sub
