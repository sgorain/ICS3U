VERSION 5.00
Begin VB.Form NumberFormat 
   Caption         =   "Form1"
   ClientHeight    =   6135
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   7995
   LinkTopic       =   "Form1"
   ScaleHeight     =   6135
   ScaleWidth      =   7995
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Run 
      Caption         =   "&Run"
      Height          =   855
      Left            =   2760
      TabIndex        =   2
      Top             =   5040
      Width           =   1575
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   855
      Left            =   4560
      TabIndex        =   1
      Top             =   5040
      Width           =   1455
   End
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   855
      Left            =   6240
      TabIndex        =   0
      Top             =   5040
      Width           =   1455
   End
End
Attribute VB_Name = "NumberFormat"
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

Private Sub Run_Click()

End Sub
