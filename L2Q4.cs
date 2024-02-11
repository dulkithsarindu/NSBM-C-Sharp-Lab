using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Product
    {
        public string ProductName;
        public int Price;

        public Product(string productname, int price)
        {
            ProductName = productname;  
            Price = price;  
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("mars", 450);

            Console.WriteLine($"Product Name : {product1.ProductName} \nPrice : {product1.Price}");
            Console.ReadLine();
        }
    }
}
