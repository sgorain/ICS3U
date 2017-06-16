VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6855
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   7920
   LinkTopic       =   "Form1"
   ScaleHeight     =   6855
   ScaleWidth      =   7920
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Run 
      Caption         =   "&Run"
      Height          =   855
      Left            =   720
      TabIndex        =   2
      Top             =   5640
      Width           =   1695
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   795
      Left            =   2880
      TabIndex        =   1
      Top             =   5640
      Width           =   1935
   End
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   855
      Left            =   5160
      TabIndex        =   0
      Top             =   5520
      Width           =   1935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

End Sub

Private Sub Clear_Click()
Cls
End Sub

Private Sub End_Click()
End
End Sub

Sub Run_Click()

End Sub
