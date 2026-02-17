using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>
        {
            { "P101", 25 },
            { "P102", 0 },
            { "P103", 14 }
        };

        string inputCode = Console.ReadLine();
        
            if (inventory.ContainsKey(inputCode)){
                Console.WriteLine($"{inventory[inputCode]} items are present in the inventory");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        
        
    }
}