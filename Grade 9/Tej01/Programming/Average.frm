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
Rem Average Program
Rem Date: 2014-11-25

Private Sub Clear_Click()
Cls
End Sub

Private Sub End_Click()
End
End Sub

Private Sub Run_Click()
Dim subject1 As Integer
Dim subject2 As Integer
Dim subject3 As Integer
Dim subject4 As Integer

Dim Mark1 As Single
Dim average As Single

Dim name As String

name = InputBox("Please enter your name here", "Name") 'asks for name
subject1 = InputBox("Please enter your first subject mark here", "Subject1")
subject2 = InputBox("Please enter your second subject mark here", "Subject2")
subject3 = InputBox("Please enter your third subject mark here", "Subject3")
subject4 = InputBox("Please enter your fourth subject mark here", "Subject4") 'asks for subject marks

Mark1 = subject1 + subject2 + subject3 + subject4 'calculate mark
average = Mark1 / 4 'calculates average
name = name

MsgBox ("Your mark has been succesfully calculated " & name)
Print "Your average mark has been calculated "; name; "."; " Your average mark is"; average; "%. "; "Thank you ."

End Sub


