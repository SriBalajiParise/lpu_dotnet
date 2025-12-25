using System;
namespace December23Prob2;
 class Program
{
    public static void Main()
    {
        Cake obj =new Cake();

        Console.WriteLine("Please enter your Flavour: ");
        Console.WriteLine("Vanilla\nChocolate\nRed Velvet");
        obj.Flavour = Console.ReadLine();
        Console.WriteLine("Please enter Quantity in Kg: ");
        obj.QuantityInKg = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter Price per Kg: ");  
        obj.PricePerKg = Convert.ToDouble(Console.ReadLine());


        try
        {
            obj.CakeOrder();
            Console.WriteLine("Cake order is successful ");
            Console.WriteLine("Price after discount is : {0}",obj.CalculatePrice());
        }
        catch(InvalidFlavourException emessage)
        {
            Console.WriteLine(emessage.Message);
        }
        catch(InvalidQuantityException emessage)
        {
            Console.WriteLine(emessage.Message);
        }
        
        
    }
}