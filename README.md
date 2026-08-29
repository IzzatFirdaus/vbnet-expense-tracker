# Personal Expense Tracker CLI (VB.NET)

A modern command-line expense tracker application written in Visual Basic .NET targeting .NET 8. Demonstrates Object-Oriented Programming (OOP) design, LINQ data queries, collection handling, and interactive CLI menu structures.

## Features
- **Object-Oriented Design:** Modular breakdown separating domain entities (`Transaction`) and business management (`ExpenseManager`).
- **LINQ Integration:** Queries and filters transactions by category using native Visual Basic LINQ expressions.
- **Cross-Platform .NET 8:** Runs natively across Windows, macOS, and Linux platforms using the standard .NET SDK.

## Project Structure
```text
vbnet-expense-tracker/
├── src/
│   └── BudgetApp/
│       ├── Program.vb
│       ├── Transaction.vb
│       ├── ExpenseManager.vb
│       └── BudgetApp.vbproj
├── .vscode/
│   └── tasks.json
├── .gitignore
└── README.md
```

## Prerequisites

* **.NET 8 SDK** or higher installed on your system.

## How to Build & Run

### 1. Clone the Repository

```bash
git clone [https://github.com/IzzatFirdaus/vbnet-expense-tracker.git](https://github.com/IzzatFirdaus/vbnet-expense-tracker.git)
cd vbnet-expense-tracker
```

### 2. Run Application via .NET CLI

```powershell
dotnet run --project src/BudgetApp/BudgetApp.vbproj
```

### 3. Build via VS Code Tasks

Press `Ctrl + Shift + B` in VS Code to trigger the configured build task and run the project directly.