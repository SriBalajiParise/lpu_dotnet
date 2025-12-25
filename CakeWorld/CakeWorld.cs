using System;
namespace December23Prob2;

/// <summary>
/// code is fully working for test cases. learn about exception and check for edge cases also
/// </summary>
    class Cake
    {
        public string Flavour { get; set; }
        public int QuantityInKg{get;set;}
        public double PricePerKg{get;set;}

        public bool CakeOrder()
        {
            if(Flavour =="Chocolate"  || Flavour =="Red Velvet"  || Flavour =="Vanilla")
            {
            if (QuantityInKg > 0)
            {
                return true;
            }
            else
            {
                throw new InvalidQuantityException("Quantity must be greater than 0");
            
            }
            
        }

        else
            {
                    throw new InvalidFlavourException("Flavour is not available .Please select available flavours");
            }
        }
        


        public double CalculatePrice()
        {
            double totalPrice= QuantityInKg * PricePerKg;

            double discount=0;

            if (Flavour == "Vanilla"){
                discount=3;
            }
             else if (Flavour == "Chocolate"){
                discount=5;
            }
             else if (Flavour == "Red Velvet"){
                discount=10;
            }

            double discountedPrice=totalPrice - (totalPrice * discount/100);
            return discountedPrice;
        }

    }

    public class InvalidQuantityException:Exception
{
    public InvalidQuantityException(string message) : base(message)
    {
        
    }
}

    public class InvalidFlavourException:Exception
{
    public InvalidFlavourException(string message) : base(message)
    {
        
    }
}

