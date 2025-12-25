using System;
namespace Book;

class Progarm
{
     static void Main()
    {
        Book objbook= new Book();

        Console.WriteLine("Enter the title of the Book: ");
        string title=Console.ReadLine();
        Console.WriteLine("Enter the author of the Book: ");
        string author=Console.ReadLine();
        Console.WriteLine("Enter the title of the Book: ");
        int numPages=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the due date: ");
        DateTime dueDate=
        Console.WriteLine("Enter the returned date: ");
        DateTime returnedDate=

        Book Objbook2=new Book(title ,author,numPages, dueDate, returnedDate);
    }
}