Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim manager As New ExpenseManager()

        ' Seed data
        manager.AddTransaction("Cloud Server Hosting", 45.50D, "Infrastructure")
        manager.AddTransaction("Domain Registration", 12.00D, "Infrastructure")
        manager.AddTransaction("Office Supplies", 25.75D, "Operations")

        ' Capture console output using StringWriter
        Using writer As New StringWriter()
            Console.SetOut(writer)

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

            ' Write captured output to console AND text file
            Dim resultText As String = writer.ToString()
            
            ' Restore original console output stream
            Dim standardOutput As New StreamWriter(Console.OpenStandardOutput())
            standardOutput.AutoFlush = True
            Console.SetOut(standardOutput)

            Console.Write(resultText)
            File.WriteAllText("output.txt", resultText)
        End Using
    End Sub
End Module