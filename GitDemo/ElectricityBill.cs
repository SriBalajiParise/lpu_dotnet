using System;
namespace exercise1;

public class ElectricityBill
{
    public static void Bill()
    {
        Console.WriteLine("Enter the units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double amount=0;   //amount may be higher
        double price=0;   //final price after adding the surcharge
        if (units > 0)
        {
            if (units <= 199)
            {
                amount=units*1.20;
            }
            else if(units>=200 && units <=400)
            {
                amount=units*1.50;
            }
            else if(units >400 && units <=600)
            {
                amount=units*1.80;
            }
            else if (units > 600)
            {
                amount=units*2.00;
            }

            if (amount <= 400)
            {
                Console.WriteLine("The total electricity bill is: {0}",amount);
            }
            else
            {
            price=amount + (amount * 0.15);
            Console.WriteLine("The total electricity bill is: {0}",price);
            }
        }
        else
        {
            Console.WriteLine("Invalid Input .Enter valid  Units");
        }
        
        
    }
}
