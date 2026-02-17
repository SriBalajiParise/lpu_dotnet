using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] employeeIds = { 1001, 1002, 1001, 1003, 1002, 1001 };
        Dictionary<int, int> attendance = new Dictionary<int, int>();
        // TODO: Build frequency map and print

        foreach(var item in employeeIds)
        {
            if (attendance.ContainsKey(item))
            {
                attendance[item]++;
            }
            else
            {
                attendance[item] = 1;
            }
        }
        foreach(var item in attendance)
        {
            Console.WriteLine($"Employee Id : {item.Key} and attendance count is {item.Value}");
        }
    }
}