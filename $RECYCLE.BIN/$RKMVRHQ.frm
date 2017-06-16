VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6630
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   7980
   LinkTopic       =   "Form1"
   ScaleHeight     =   6630
   ScaleWidth      =   7980
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Run 
      Caption         =   "&Run"
      Height          =   975
      Left            =   1680
      TabIndex        =   2
      Top             =   5400
      Width           =   1575
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   855
      Left            =   3600
      TabIndex        =   1
      Top             =   5520
      Width           =   1695
   End
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   855
      Left            =   5760
      TabIndex        =   0
      Top             =   5520
      Width           =   1575
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

End Sub



