VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6630
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   8820
   LinkTopic       =   "Form1"
   ScaleHeight     =   6630
   ScaleWidth      =   8820
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Run 
      Caption         =   "Run"
      Height          =   1095
      Left            =   840
      TabIndex        =   2
      Top             =   4800
      Width           =   1815
   End
   Begin VB.CommandButton Clear 
      Caption         =   "&Clear"
      Height          =   1215
      Left            =   3600
      TabIndex        =   1
      Top             =   4920
      Width           =   2415
   End
   Begin VB.CommandButton End 
      Caption         =   "&End"
      Height          =   1095
      Left            =   6360
      TabIndex        =   0
      Top             =   5040
      Width           =   1815
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
