using System;
namespace exercise1;
public class ThreeNumber{
    public static void Largest()
    {
        Console.WriteLine("Enter the first number: ");
        int a=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int c=Int32.Parse(Console.ReadLine());

        if((a>b && a > c ) || (a==b && a>c) || (a==c && a>b))
        {
            Console.WriteLine("The Largest NUmber is: {0}",a);
        }else if(b>= c && b>= a)
        {
            Console.Write("The Largest Number is: {0}",b);
        }
        else
        {
            Console.WriteLine("The Largest Number is: {0}",c);
        }
    }

}