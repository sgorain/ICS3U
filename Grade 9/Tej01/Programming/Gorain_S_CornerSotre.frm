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

Dim item As String
Dim price As Integer
Dim quantity As Integer
Dim subtotal As Single
Dim totalbill As Single
Dim HST As Single

item = InputBox("What is the item being bought")
price = InputBox("What is the price of the item")
quantity = InputBox("How many items are being bought")

subtotal = price * quantity
totalbill = subtotal + (subtotal * 0.13)
HST = subtotal * 0.13

Print "Your subtotal is $"; subtotal
Print "Your HST is $"; HST
Print "Your totalbill is $ "; totalbill

End Sub
