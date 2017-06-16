VERSION 5.00
Begin VB.Form Run 
   Caption         =   "Form1"
   ClientHeight    =   7080
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   8730
   LinkTopic       =   "Form1"
   ScaleHeight     =   7080
   ScaleWidth      =   8730
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   1335
      Left            =   6360
      TabIndex        =   2
      Top             =   5280
      Width           =   2055
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   1215
      Left            =   3360
      TabIndex        =   1
      Top             =   5280
      Width           =   2415
   End
   Begin VB.CommandButton Run 
      Caption         =   "&Run"
      Height          =   975
      Left            =   960
      TabIndex        =   0
      Top             =   5400
      Width           =   1935
   End
End
Attribute VB_Name = "Run"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Private Sub Clear_Click()
Cls
End Sub

Private Sub End_Click()
End
End Sub

Private Sub Run_Click()

Dim code As String

code = InputBox("Please enter your password")

If code = "code" Then
MsgBox "Welcome"
Print "you have been succesful"

Else:
MsgBox "Your password is incorrect"

End If

End Sub
