using System;
namespace exercise1;

public class LeapYear
{
    public static void YearChecker()
    {
        Console.WriteLine("Enter the Year: ");
        int year=Int32.Parse(Console.ReadLine());
        if (year > 0)
        {
            if(year%400==0 || (year%4==0 && year % 100 != 0))
            {
                Console.WriteLine("{0} is a Leap year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year",year);
            }
        }
        else
        {
            Console.WriteLine("Enter a valid year");
        }
    }
}
