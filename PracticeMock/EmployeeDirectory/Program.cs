using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> branch1 = new Dictionary<int, string>
        {
            { 101, "Anu" },
            { 102, "Dev" }
        };

        Dictionary<int, string> branch2 = new Dictionary<int, string>
        {
            { 102, "Devika" },
            { 103, "Rahul" }
        };

        Dictionary<int,string> answer = new Dictionary<int,string>(branch2);
        foreach(var item in branch1)
        {
            if (answer.ContainsKey(item.Key))
            {
                continue;
            }
            else
            {
                answer.Add(item.Key,item.Value);
            }
        }
        foreach (var item in answer)
        {
            Console.WriteLine($"ID: {item.Key} , Name: {item.Value}");
        }
    }
}