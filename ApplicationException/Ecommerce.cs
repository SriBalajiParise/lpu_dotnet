using System;

namespace ApplicationException;

public class Ecommerce
{
    public string UserName{get;set;}
    public double WalletBalance{get;set;}
    public double TotalPurchaseAmount{get;set;}

    public Ecommerce(string name,double balance, double amount)
    {
        UserName = name;
        WalletBalance = balance;
        TotalPurchaseAmount = amount;
    }

    public void MakePayment(string name, double balance, double amount)
    {
        if(balance > amount){
            Console.WriteLine("Payment Successful");
            
        }
        else
        {
            throw new InsufficientWalletBalanceException("Insufficient wallet balance.");
        }
    }
}

public class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException(string message) : base(message)
    {
    }
   
}


