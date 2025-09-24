Option Explicit
Public Sub AddRecord(ByVal id As Long, ByVal name As String)
    On Error Resume Next
    ' Simulated insecure file write using a hardcoded path
    Dim fpath As String
    fpath = "C:\temp\vuln_data.txt" ' hardcoded path
    Open fpath For Append As #1
    Print #1, id & "," & name
    Close #1
End Sub

' Vulnerable: executing system command constructed from input
Public Sub RunCommand(cmd As String)
    Shell cmd ' dangerous if cmd contains user input
End Sub
