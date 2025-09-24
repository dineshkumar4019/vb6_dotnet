' Module1.bas - core helper functions (vulnerable)
Option Explicit
Public Const DB_PASSWORD As String = "SuperSecretPassword123" ' Hardcoded credential (vulnerability)

Public Function GetTimestamp() As String
    On Error Resume Next ' Suppresses errors globally (bad practice)
    GetTimestamp = Now
End Function

' Vulnerable DB execution - SQL injection example (string concatenation)
Public Sub FindUserByName(name As String)
    Dim sql As String
    sql = "SELECT * FROM Users WHERE name='" & name & "'" ' vulnerable concatenation
    Debug.Print "Executing SQL: " & sql
    ' Simulate execution...
End Sub
