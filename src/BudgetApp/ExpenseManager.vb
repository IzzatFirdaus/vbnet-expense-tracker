Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class ExpenseManager
    Private ReadOnly _transactions As New List(Of Transaction)()
    Private _nextId As Integer = 1

    Public Sub AddTransaction(description As String, amount As Decimal, category As String)
        Dim t As New Transaction(_nextId, description, amount, category)
        _transactions.Add(t)
        _nextId += 1
    End Sub

    Public Function GetAllTransactions() As List(Of Transaction)
        Return _transactions
    End Function

    Public Function GetTotalExpenses() As Decimal
        Return _transactions.Sum(Function(t) t.Amount)
    End Function

    Public Function GetExpensesByCategory(category As String) As List(Of Transaction)
        ' Using LINQ for VB.NET
        Dim query = From t In _transactions
                    Where t.Category.Equals(category, StringComparison.OrdinalIgnoreCase)
                    Select t

        Return query.ToList()
    End Function
End Class