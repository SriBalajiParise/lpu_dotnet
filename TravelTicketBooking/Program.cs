﻿using System;
namespace TravelTicketBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelTicketBooking obj =new TravelTicketBooking();
            Console.WriteLine("Enter ypur passenger ID: ");
            obj.Id=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter passenger name: ");
            obj.Name=Console.ReadLine();
            Console.WriteLine("Enter passenger age: ");
            obj.Age=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Select travel type: \n1.Bus\n2.Train\n3.Flight");
            obj.TravelType=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter base fare: ");
            obj.BaseFare=Double.Parse(Console.ReadLine());
            Console.WriteLine("Are you Government Employee: (true/false)");
            obj.IsGovernmentEmployee=Boolean.Parse(Console.ReadLine());

            if (obj.Age < 0)
            {
                Console.WriteLine("Enter valid age");
            }
             else if (obj.Age>0 && obj.Age < 5)
            {
                Console.WriteLine("Ticket is free for age below 5 years.");
            }
            else if(obj.Age>80){
                Console.WriteLine("Medical clearance is required for people who are above 80 years of age");
            }
            else
            {
                switch (obj.TravelType){

                        case 1:
                        {
                            Console.WriteLine("Please select travel class: \nSleeper\nSeater");
                            obj.ClassSelection=Console.ReadLine();
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Please select travel class: \nGeneral\nSleeper\nAC");
                            obj.ClassSelection=Console.ReadLine();
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine("Please select travel type: \nEconomy\nBussiness");
                            obj.ClassSelection=Console.ReadLine();
                            break;
                        }
                
                }

                Console.WriteLine("Passenger ID: "+obj.Id);
                Console.WriteLine("Passenger Name: "+obj.Name);
                Console.WriteLine("Passenger Travel type: "+obj.TravelType);
                Console.WriteLine("Passenger travel class: "+obj.ClassSelection);
                Console.WriteLine("Passenger Base fare: "+obj.BaseFare);
                Console.WriteLine("Passenger Final Fare: "+obj.FinalFare());
                double fareAfterClass = obj.FareMultiplierCalculation();
                double discountAmount = fareAfterClass - obj.FinalFare();

                Console.WriteLine("Passenger Discount Applied: " + discountAmount);

                obj.BookingStatus();
            }

    


        }
    }
}