Imports System

Module Program
    Sub Main(args As String())
        Dim manager As New ExpenseManager()

        ' Seed data
        manager.AddTransaction("Cloud Server Hosting", 45.50D, "Infrastructure")
        manager.AddTransaction("Domain Registration", 12.00D, "Infrastructure")
        manager.AddTransaction("Office Supplies", 25.75D, "Operations")

        Console.WriteLine("=== VB.NET Personal Expense Tracker ===")
        Console.WriteLine()

        Console.WriteLine("--- All Recorded Transactions ---")
        For Each t In manager.GetAllTransactions()
            Console.WriteLine(t)
        Next

        Console.WriteLine()
        Console.WriteLine($"Total Overall Expenses: ${manager.GetTotalExpenses():F2}")

        Console.WriteLine()
        Console.WriteLine("--- Filtered: Infrastructure Category ---")
        Dim infraItems = manager.GetExpensesByCategory("Infrastructure")
        For Each t In infraItems
            Console.WriteLine(t)
        Next
    End Sub
End Module