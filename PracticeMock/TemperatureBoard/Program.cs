using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> temperature = new Dictionary<string, int>
        {
            { "Chennai", 38 },
            { "Delhi", 41 },
            { "Bengaluru", 29 }
        };

        // TODO: Iterate and find max temperature city
        string firstKey = temperature.Keys.First();
        int max = temperature[firstKey];


        foreach(var item in temperature)
        {
            if(item.Value > max)
            {
                max = item.Value;
            }
        }
        Console.WriteLine("Max temperature is: " + max);
    }
}