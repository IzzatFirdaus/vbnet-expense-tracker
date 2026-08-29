Imports System

Public Class Transaction
    Public Property Id As Integer
    Public Property Description As String
    Public Property Amount As Decimal
    Public Property Category As String
    Public Property EntryDate As DateTime

    Public Sub New(id As Integer, description As String, amount As Decimal, category As String)
        Me.Id = id
        Me.Description = description
        Me.Amount = amount
        Me.Category = category
        Me.EntryDate = DateTime.Now
    End Sub

    Public Overrides Function ToString() As String
        Return $"[{EntryDate:yyyy-MM-dd}] ID: {Id} | {Category} | {Description} - ${Amount:F2}"
    End Function
End Class