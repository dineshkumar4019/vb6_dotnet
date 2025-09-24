VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
End
Attribute VB_Name = "Form1"
Private Sub Form_Load()
    On Error Resume Next ' hides errors
    MsgBox "UIApp started"
End Sub

' Vulnerable: building SQL from text box input (simulated)
Public Sub SearchButton_Click(txtUser As String)
    On Error Resume Next
    Dim query As String
    query = "SELECT * FROM Users WHERE username='" & txtUser & "'"
    Debug.Print "Query: " & query
End Sub
