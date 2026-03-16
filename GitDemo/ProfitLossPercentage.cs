using System;
namespace exercise1;

public class ProfitLossPercentage
{
    public static void Calculator()
    {
        Console.WriteLine("Enter the Cost Price:");
        double costPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Selling Price:");
        double sellingPrice = double.Parse(Console.ReadLine());
        if(costPrice>0 && sellingPrice > 0)
        {
            if (sellingPrice > costPrice)
            {
                double profit=sellingPrice-costPrice;
                double profitPercentage=(profit/costPrice)*100;
                Console.WriteLine("Profit Percentage is: {0}", profitPercentage + "%");

            }
            else
            {
                double loss=costPrice-sellingPrice;
                double lossPercentage=(loss/costPrice)*100;
                Console.WriteLine("Loss Percentage is: {0}", lossPercentage + "%");
            }
        }
        else
        {
            Console.WriteLine("Invalid Price Amounts.Please enter valid amount numbers");
        }

    }

}
