using System;
using System.Collections.Generic;

public class Ledger<T> where T : Transaction
{
    private List<T> entries;

    public Ledger()
    {
        entries = new List<T>();
    }

    public void AddEntry(T entry)
    {
        entries.Add(entry);
    }

    public decimal CalculateTotal()
    {
        decimal totalAmount = 0;

        foreach (T item in entries)
        {
            totalAmount = totalAmount + item.Amount;
        }

        return totalAmount;
    }

    public List<T> GetAll()
    {
        return entries;
    }
}
