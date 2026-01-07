using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Income
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();

        IncomeTransaction income = new IncomeTransaction();
        income.Id = 1;
        income.Date = DateTime.Now;
        income.Amount = 500;
        income.Source = "Main Cash";
        income.Description = "Petty cash replenishment";

        incomeLedger.AddEntry(income);

        // Expense
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        ExpenseTransaction expense1 = new ExpenseTransaction();
        expense1.Id = 1;
        expense1.Date = DateTime.Now;
        expense1.Amount = 20;
        expense1.Category = "Stationery";
        expense1.Description = "Pens and notebooks";

        expenseLedger.AddEntry(expense1);

        ExpenseTransaction expense2 = new ExpenseTransaction();
        expense2.Id = 2;
        expense2.Date = DateTime.Now;
        expense2.Amount = 15;
        expense2.Category = "Food";
        expense2.Description = "Team snacks";

        expenseLedger.AddEntry(expense2);

        // For Calculations
        decimal totalIncome = incomeLedger.CalculateTotal();
        decimal totalExpense = expenseLedger.CalculateTotal();
        decimal netBalance = totalIncome - totalExpense;

        Console.WriteLine("---- Petty Cash Summary ----");
        Console.WriteLine("Total Income  : ₹" + totalIncome);
        Console.WriteLine("Total Expense : ₹" + totalExpense);
        Console.WriteLine("Net Balance   : ₹" + netBalance);
        Console.WriteLine();

        



        Console.WriteLine("---- Transaction Details ----");

        List<Transaction> allTransactions = new List<Transaction>();
        allTransactions.AddRange(incomeLedger.GetAll());
        allTransactions.AddRange(expenseLedger.GetAll());

        foreach (Transaction transaction in allTransactions)
        {
            Console.WriteLine(transaction.GetSummary());
        }
    }
}
