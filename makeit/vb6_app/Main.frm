VERSION 5.00
Begin VB.Form Main  frm_Main 
   Caption         =   "Legacy VB6 App"
   ClientHeight    =   4890
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6545
Begin VB.CommandButton Command1 
   Caption         =   "Run Process"
   Height          =   495
   Left            =   240
   Top             =   360
   Width           =   1215
End
End
' Event handlers
Private Sub Command1_Click()
    Call Module1.ProcessData("input.txt")
End Sub
