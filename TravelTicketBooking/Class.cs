using System;

namespace TravelTicketBooking;

class TravelTicketBooking
{   
        public int Id{get;set;}

        public string Name{get;set;}

        public int Age{get;set;}

       public int TravelType{get;set;}

        public double BaseFare{get;set;}

        public Boolean IsGovernmentEmployee{get;set;}

        public string ClassSelection{get;set;}


        public double FareMultiplierCalculation()
    {
        double fareAfterClass=0;
        if (TravelType==1 && ClassSelection == "Sleeper")
        {
            fareAfterClass=BaseFare*1.2;
        }
        else if (TravelType==1 && ClassSelection == "Seater")
        {
            fareAfterClass=BaseFare*1.0;
        }
        else if (TravelType==2 && ClassSelection == "General")
        {
            fareAfterClass=BaseFare*1.0;
        }
        else if (TravelType==2 && ClassSelection == "Sleeper")
        {
            fareAfterClass=BaseFare*1.3;
        }
       else  if (TravelType==2 && ClassSelection == "AC")
        {
            fareAfterClass=BaseFare*1.6;
        }
        if (TravelType==3 && ClassSelection == "Economy")
        {
            fareAfterClass=BaseFare*2.5;
        }
        if (TravelType==3 && ClassSelection == "Bussiness")
        {
            fareAfterClass=BaseFare*3.5;
        }
        return fareAfterClass;
    }

    public double FinalFare()
    {
        
        double finalFare=0;
        double discount=0;

        if (Age>=5 && Age <=12)
        {
            discount=0.50*FareMultiplierCalculation();
        }
        else if (Age>=60)
        {
            discount=0.30*FareMultiplierCalculation();
        }
        else if (IsGovernmentEmployee)
        {
            discount=0.15*FareMultiplierCalculation();
        }
        else
        {
            discount=0;
        }

        double fareAfterClass=FareMultiplierCalculation();
        double discountAmount = fareAfterClass * discount;
        
        return fareAfterClass - discount;

    }

    public void BookingStatus()
    {
        if(FinalFare() >= 10000)
        {
            if (TravelType == 3)
            {
                Console.WriteLine("Booking status is Confirmed");
            }
            else
            {
                Console.WriteLine("Booking status is WaitingList");
            }
        }
        else
        {
            Console.WriteLine("Booking status is Confirmed");
        }
    }


}