using System;
namespace CabFare;

class  Program{
    static void Main()
    {
        
        CabDetails obj=new CabDetails();

        Console.WriteLine("Enter the booling Id: ");
        obj.BookingId =Console.ReadLine();
        Console.WriteLine("Enter the cab type \nHatchbatch\n2.SUV\n3.Sedan");
        obj.CabType =Console.ReadLine();
        Console.WriteLine("Enter the distance in km: ");
        obj.Distance=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the waitingtime in minutes");
        obj.WaitingTime=Int32.Parse(Console.ReadLine());
        

        if (!obj.ValidateBookingId())
        {
            Console.WriteLine("Invalid booking Details");
        }
        else
        {
            Console.WriteLine("The fare amount is {0}",obj.CalculateFareAmount());
        }
    }
}