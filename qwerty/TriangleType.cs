using System;
namespace exercise1;

public class TriangleType
{
    public static void TypeOfTriangle()
    {
        Console.WriteLine("Enter the length of the first side of the triangle:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of the second side of the triangle:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of the third side of the triangle:");
        double side3 = Convert.ToDouble(Console.ReadLine());
        if(side1>0 && side2>0 && side3>0)
        {
        if(side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if(side1!= side2 && side1 != side3 && side2 != side3)
        {
            Console.WriteLine("The triangle is scalene.");
        }
        else
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        }
        else
        {
            Console.WriteLine("Invalid triangle sides. Lengths must be positive.");
        }
    }
}
