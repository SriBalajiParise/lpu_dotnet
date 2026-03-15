using System;
public class User
{
    public string Name{get;set;}
    public string Password{get;set;}
    public string ConfirmPassword{get;set;}

    public User(string name , string password, string confirmpassword)
    {
        Name = name;
        Password = password;
        ConfirmPassword = confirmpassword;
    }

    public void ValidatePassword(string name, string password, string confirmationPassword)
    {
        if(password == confirmationPassword)
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            throw new IncorrectException("Both the passwords do not match");
        
        }
        
    }
}

public class IncorrectException: Exception{
    public IncorrectException(string message):base(message)
    {

    }
}

class Program
{
    public static void Main()
    {
        try
        {
        User obj = new User("Balaji", "1Ae45", "12345");
        obj.ValidatePassword(obj.Name, obj.Password, obj.ConfirmPassword);
        }
        catch(IncorrectException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch(Exception ex)
        {
            Console.WriteLine("Error occured : " + ex.Message);
        }
    }
}