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

Dim age As Single
Dim DOB As Integer
Dim charge As Integer
Dim tax As Single
Dim total As Single

Print Tab(2); "RCI ENTERTAINMENT LTD."
Print Tab(2); "569 Jane St.-Toronto ON"
Print Tab(2); "www.runnymedecollegiate.com"


DOB = InputBox("Which year were you born on?")

age = 2014 - DOB

If age <= 12 Then

charge = 0
tax = charge * 0.13
total = charge + tax
Print Tab(5); "Age: "; Tab(20); age
Print Tab(5); "Child Price: "; Tab(20); charge
Print Tab(5); "Taxes: "; Tab(20); tax
Print Tab(5); "Amount Due: "; Tab(20); total


ElseIf age >= 12 And age <= 18 Then

charge = 5
tax = charge * 0.13
total = charge + tax
Print Tab(5); "Age: "; Tab(20); age
Print Tab(5); "Youth Price: "; Tab(20); charge
Print Tab(5); "Taxes: "; Tab(20); tax
Print Tab(5); "Amount Due: "; Tab(20); total

ElseIf age >= 17 And age <= 65 Then
charge = 15
tax = charge * 0.13
total = charge + tax
Print Tab(5); "Age: "; Tab(20); age
Print Tab(5); "Adult Price: "; Tab(20); charge
Print Tab(5); "Taxes: "; Tab(20); tax
Print Tab(5); "Amount Due: "; Tab(20); total


ElseIf age >= 64 Then
charge = 0
tax = charge * 0.13
total = charge + tax
Print Tab(5); "Age: "; Tab(20); age
Print Tab(5); "Senior Pricw Price: "; Tab(20); charge
Print Tab(5); "Taxes: "; Tab(20); tax
Print Tab(5); "Amount Due: "; Tab(20); total

Else
End If


End Sub



