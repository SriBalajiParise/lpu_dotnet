using System;
namespace exercise1;

public class Height
{
    public static void HeightCalc()
    {
        Console.WriteLine("Enter the height: ");
        int n=int.Parse(Console.ReadLine());
        if (n < 150)
        {
            Console.WriteLine("Dwarf");
        }else if (150 <= n && n < 165)
        {
            Console.WriteLine("Average");
        }else if(165<=n && n < 195)
        {
            Console.WriteLine("Tall");
        }
        else {
            Console.WriteLine("Abnormal");
        }
    }
}
