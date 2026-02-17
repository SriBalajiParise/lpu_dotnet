using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] attempts = { "raj", "kavi", "raj", "raj", "kavi" ,"kavi"};
        Dictionary<string, int> failedAttempts = new Dictionary<string, int>();
        // TODO: Count attempts and print users with attempts >= 3

        foreach(var item in attempts)
        {
            if (failedAttempts.ContainsKey(item))
            {
                failedAttempts[item]++;
            }
            else
            {
                failedAttempts[item]= 1;
            }
            
        }
        foreach(var item in failedAttempts)
        {
            if(item.Value >= 3)
            {
                Console.WriteLine($"{item.Key}");
            }
            
        }
    }
}