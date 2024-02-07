using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02_Q1
{
    class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("The Famous Five", "Enid Blyton");

            Console.WriteLine("Book Information:");
            Console.WriteLine("Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadLine(); // Keep console window open
        }
    }
}
