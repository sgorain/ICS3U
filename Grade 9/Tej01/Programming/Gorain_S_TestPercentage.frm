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
      Height          =   855
      Left            =   6120
      TabIndex        =   0
      Top             =   5880
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Clear_Click()
Cls
End Sub

Private Sub End_Click()
End
End Sub

Private Sub Run_Click()

Dim TestName As String
Dim StudentName As String
Dim Score As Integer
Dim Total As Integer
Dim Percentage As Single

TestName = InputBox("Please enter the name of the test.")
StudentName = InputBox("Please enter the Student`s name.")
Score = InputBox("Please enter the test score.")
Total = InputBox("Please how many marks the test is out of.")

Percentage = Score / Total * 100

Print "The percentage of "; StudentName; "'s "; TestName; " test is "; Percentage; "%"

End Sub
