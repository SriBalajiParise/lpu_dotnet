using System;
namespace DoSelectTest1;

class Program
{
    public static void Main()
    {
        IList<Person> person =new List<Person>();
        person.Add(new Person(){Name ="Aarya", Address="101", Age=69});
        person.Add(new Person(){Name="Daniel",Address="104",Age=40});
        person.Add(new Person(){Name="Ira",Address="801",Age=25});
        person.Add(new Person(){Name="Jennifer",Address="1704",Age=33});

        PersonImplementation objPersonImplementation =new PersonImplementation();

        Console.WriteLine(objPersonImplementation.GetName(person));
        Console.WriteLine(objPersonImplementation.Average(person));
        Console.WriteLine(objPersonImplementation.Max(person));

        



    }
}