using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02_Q5
{
     class LibraryBook
    {
        public string Auther;
        public string Title;
        public bool Available;

        //constructor( A constructor is a special method that is used to initialize objects)
        public LibraryBook(string title,string auther)
        {
            Title = title;
            Auther = auther;
            Available = true;

            public void BorrowBook()
            {
                if (Available)
                {
                    Available = false;
                    Console.WriteLine($"Book '{Title}' by {Auther} has been borrowed.");
                    //using the $ symbol allows you to directly include variables.
                }
                else
                {
                    Console.WriteLine($"Book '{Title}' by {Auther} is not available.");

                }

            Public void ReturnBook()
                if (!Available)
                {
                    Available = true;
                    Console.WriteLine($"Book '{Title}' by {Auther} has been returned.");
                }
                else
                {
                    Console.WriteLine($"Book '{Title}' by {Auther} has not been returned.");
                }


            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("Famous Five", "Enid Blyton");
            LibraryBook book2 = new LibraryBook("The Great Gatsby", "F.Scott");
            LibraryBook book3 = new LibraryBook("To Kill a MockinBird", "Harper Lee");

            //Borrow Some Books
            book1.BorrowBook();
            book2.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();//Trying to borrow the same book

            //Return Books
            book2.BorrowBook();
            book1.BorrowBook();
        }
    }
}
