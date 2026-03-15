using System;
class Number
{
    public string Name { get; set; }
    public string phoneNumber { get; set; }
}

class Validation
{
    public Number ValidatePhoneNumber(string name, string phoneNumber)
    {
        Number number = new Number();
        if (phoneNumber.Length == 10)
        {
            number.Name = name;
            number.phoneNumber=phoneNumber;
        
        }

         else
        {
            throw new numberException("Invalid phone number");
        }

        return number;
    }
    public class numberException : Exception
    {
        public numberException(string message) : base(message)
        {
            
        }
    }
}

class Program
{
    public static void Main()
    {
        Validation obj = new Validation();
        try
        {
            
            Number number = obj.ValidatePhoneNumber("John Doe", "1234567890");
            Console.WriteLine($"Name: {number.Name}, Phone Number: {number.phoneNumber}");

        }
        catch (Validation.numberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}