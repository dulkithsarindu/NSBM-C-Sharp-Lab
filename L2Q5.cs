using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{   
    class LibraryBook
    {
        public string title;
        public string author;
        public string available = "Available";

        public LibraryBook(string Title, string Author)
        {
            title = Title;
            author = Author;
        }

        public void BorrowBook()
        {
            available = "Not Available";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("book1", "Ranil Wickramasinghe" );
            LibraryBook book2 = new LibraryBook("book2", "Anura Dissanayake");
            LibraryBook book3 = new LibraryBook("book3", "Mahinda Rajapaksa");
            LibraryBook book4 = new LibraryBook("book4", "Sajith Premadasa");
            LibraryBook book5 = new LibraryBook("book5", "Keheliya Rambukwella");

            book1.BorrowBook();

            Console.WriteLine($"{book1.title} is {book1.available}");
            Console.WriteLine($"{book2.title} is {book2.available}");
            Console.WriteLine($"{book3.title} is {book3.available}");
            Console.WriteLine($"{book4.title} is {book4.available}");
            Console.WriteLine($"{book5.title} is {book5.available}");
            Console.ReadLine();
        }
    }
}
