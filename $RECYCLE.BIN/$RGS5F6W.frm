VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6240
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   8475
   LinkTopic       =   "Form1"
   ScaleHeight     =   6240
   ScaleWidth      =   8475
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Run 
      Caption         =   "&Run"
      Height          =   975
      Left            =   2520
      TabIndex        =   2
      Top             =   5040
      Width           =   1335
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   855
      Left            =   4440
      TabIndex        =   1
      Top             =   5040
      Width           =   1455
   End
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   855
      Left            =   6360
      TabIndex        =   0
      Top             =   5040
      Width           =   1455
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
'Snehan Gorain'
'November 21, 2014'
'area calculator'

Dim length As Integer
Dim width As Integer

length = InputBox("what is the length of the room?")
width = InputBox("what is the width of the room?")

are = length * width

Print "The length of the room is: "; length
Print "The width of the room is: "; width
Print "The area of the room is: "; Area
End Sub
