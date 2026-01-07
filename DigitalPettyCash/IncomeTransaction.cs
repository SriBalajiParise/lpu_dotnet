public class IncomeTransaction : Transaction
{
    public string Source { get; set; }

    public override string GetSummary()
    {
        string summary;
        
        summary = "[INCOME] " + Date.ToShortDateString()+ " | Source: " + Source+ " | Amount: ₹" + Amount+ " | Description: " + Description;


        return summary;
    }
}
