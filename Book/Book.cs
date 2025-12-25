using System;

namespace Book;

public class Book
{
        public string title;

        public string author;

        public int numPages;

        public DateTime dueDate;

        public DateTime returnedDate;
        
        public Book()
    {
        
    }

        public Book(string title , string author , int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title=title;
        this.author=author;
        this.numPages=numPages;
        this.dueDate=dueDate;
        this.returnedDate=returnedDate;
    }



}
