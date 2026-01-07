public class ExpenseTransaction : Transaction
{
    public string Category { get; set; }

    public override string GetSummary()
    {
        string summary;

        summary = "[EXPENSE] "+Date.ToShortDateString()+" | Category: " + Category+ " | Amount: ₹" + Amount+ " | Description: " + Description;

        return summary;
    }
}
