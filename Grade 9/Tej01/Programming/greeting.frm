VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   7125
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   9105
   LinkTopic       =   "Form1"
   ScaleHeight     =   7125
   ScaleWidth      =   9105
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Run 
      Caption         =   "&Run"
      Height          =   975
      Left            =   960
      TabIndex        =   2
      Top             =   5640
      Width           =   1695
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   975
      Left            =   3480
      TabIndex        =   1
      Top             =   5640
      Width           =   1935
   End
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   975
      Left            =   6000
      TabIndex        =   0
      Top             =   5640
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
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

Dim name As String
name = InputBox("What is your name?", "Greeting")
MsgBox "Hello " & name, 16, "Greeting"

End Sub





