using System;
namespace exercise1;
    public class GradeDescription
{
    public static void Grade()
    {
        Console.WriteLine("Enther your grade (E,V,G,A,F): ");
        char ch=Console.ReadLine()[0];
        switch (ch)
        {
            case 'E':
            Console.WriteLine("Excellent");
            break;
            case 'V':
            Console.WriteLine("Very Good"); 
            break;
            case 'G':   
            Console.WriteLine("Good");
            break;
            case 'A':
            Console.WriteLine("Average");   
            break;
            case 'F':
            Console.WriteLine("Fail");
            break;
        }
    }
}