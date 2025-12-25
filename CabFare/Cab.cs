using System;

namespace CabFare;

/// <summary>
/// all the test are passing but the edge cases are not checked 
/// </summary>





public class Cab
{
        public string BookingId{get;set;}
        public string CabType{get;set;}
        public double Distance{get;set;}

        public int WaitingTime{get;set;}

}

public class CabDetails:Cab
{
        public bool ValidateBookingId()
    {
        if (BookingId.Length != 6)
        {
            return false;
        }
        if (!BookingId.StartsWith("AC@"))
        {
            return false;
        }
        for(int i = 3; i < 6; i++)
        {   
            char ch=BookingId[i];

            if (!char.IsDigit(ch))  
            {
                return false;
            }
            
        }

        if (CabType!="Hatchback" && CabType!="SUV" && CabType != "Sedan")
        {
            return false;
        }

        return true;
    }

    public double CalculateFareAmount()
    {
        int pricePerKm=0;
        switch (CabType)
        {
            case "Hatchback":
                {
                    pricePerKm=10;
                    break;
                }
                case "Sedan":
                {
                    pricePerKm=20;
                    break;
                }
                case "SUV":
                {
                    pricePerKm=30;
                    break;
                }
                
        }

        double waitingCharge=Math.Sqrt(WaitingTime);
        double fare=(Distance*pricePerKm) + waitingCharge;

        return fare;
    }
}
