using System;
namespace ApplicationException;
class Program
{
    public static void Main()
    {

        try
        {
            Ecommerce obj = new Ecommerce("John",250,350);

       

        obj.MakePayment(obj.UserName, obj.WalletBalance, obj.TotalPurchaseAmount);
        }

        catch(InsufficientWalletBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch(Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);

        }
        

    }
}