VERSION 5.00
Begin VB.Form Template 
   Caption         =   "Form1"
   ClientHeight    =   9165
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   11580
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   9165
   ScaleWidth      =   11580
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "&End"
      Height          =   975
      Left            =   9000
      TabIndex        =   2
      Top             =   7560
      Width           =   1815
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Clear"
      Height          =   1455
      Left            =   5880
      TabIndex        =   1
      Top             =   7440
      Width           =   2175
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Start"
      Height          =   1335
      Left            =   3360
      TabIndex        =   0
      Top             =   7320
      Width           =   2175
   End
End
Attribute VB_Name = "Template"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

End Sub

Private Sub Command2_Click()
Cls
End Sub

Private Sub Command3_Click()
End
End Sub

Private Sub Form_Load()

End Sub
