using System;
using System.Linq;


namespace DoSelectTest1;

public class PersonImplementation
{
    public string GetName(IList<Person> person)
    {
        string result="";
        foreach(var item in person)
        {
            result +=$"{item.Name} {item.Address }";
        }

        return result;
    }

    public double Average(IList<Person> person)
    {
        double total=0;
        double count=0;
        foreach(var item in person)
        {
            total+=item.Age;
            count++;
        }
        double average=total/count;
        return average;

    }

    public int Max(IList<Person> person)
    {
        int max=person.Max(n=>n.Age);

        return max;
    }

}
