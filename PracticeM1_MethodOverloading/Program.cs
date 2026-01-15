using System;

namespace MethodOverloading;

class Program
{
    public static void Main()
    {
        Source sourceobj = new Source();   

        Console.WriteLine(sourceobj.Add(1,2,3));
        Console.WriteLine(sourceobj.Add(1.5,2.5,3.5));
    }
}