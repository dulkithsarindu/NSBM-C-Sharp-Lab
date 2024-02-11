using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        class Book
        {
            public string title;
            public string author;
        }
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rawling";

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);    
            Console.ReadLine();
        }
    }
}
