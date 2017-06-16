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

Dim w As Integer
Dim l As Integer
Dim h As Integer
Dim v As Double

w = InputBox("Please enter the room's width")
l = InputBox("Please enter the room's length")
h = InputBox("Please enter the room's height")

v = w * l * h

Print "The width is"; w
Print "The length is"; l
Print "The height is"; h
Print "The volume of the room is"; v; "."

End Sub
