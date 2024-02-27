using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class product
    {
        private int productid;
        private string productName;
        private int price;
        private int productQuantity;

        public product(int Productid, string ProductName, int Price, int ProductQuantity)
        {
            productid = Productid;
            productName = ProductName;
            price = Price;
            productQuantity = ProductQuantity;
        }
        public int Productid
        {
            get
            {
                return productid;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
        }
        public int ProductQuantity
        {
            get
            {
                return productQuantity;
            }
        }
        public void AddProducts()
        {
            productQuantity += 1;
        }
        public void BuyProducts()
        {
            productQuantity -= 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            product laptop = new product(101, "Laptop", 800, 10);

            laptop.AddProducts();

            Console.WriteLine($"Product id: {laptop.Productid}");
            Console.WriteLine($"Product Name: {laptop.ProductName}");
            Console.WriteLine($"Price: {laptop.Price}");
            Console.WriteLine($"Quantity: {laptop.ProductQuantity}");
            Console.ReadLine();
        }
    }
}
