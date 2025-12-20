using System;
namespace exercise1;

public class AddmissonEligibility
{
    public static void Eligibility()
    {
        Console.WriteLine("Enter the marks obtained in Maths: ");
        int maths=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks obtained in Physics: ");
        int physics=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks obtained in Chemistry: "); 
        int chemistry=Int32.Parse(Console.ReadLine());
        int total=maths+physics+chemistry;
        if(maths>=65 && physics>=55 && chemistry>=50 && (total >= 180 ||maths + physics >= 140))
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
