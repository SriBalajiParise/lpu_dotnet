using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> courses = new Dictionary<string, int>
        {
            { "CSharp", 30 },
            { "SQL", 28 },
            { "Azure", 15 }
        };

        string cancelledCourse = Console.ReadLine();
        // TODO: Remove key if available and print remaining courses

        foreach(var item in courses)
        {
            if(courses.ContainsKey(cancelledCourse))
            {
                courses.Remove(cancelledCourse);
            }
        }
        foreach(var item in courses)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}