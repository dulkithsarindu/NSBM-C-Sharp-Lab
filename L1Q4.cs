using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter upto which fibonacci number you want to display");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("fibonacci series displays below");
            for (int i = 0; i <= num; i++)
            {
                int result = fibo(i);
                Console.WriteLine(result);
               
            }
            
            Console.ReadLine();
        }
        static int fibo(int i)
        {
            if (i <= 1)
            {
               return i;
            }
            else
            {
               return fibo(i - 1) + fibo(i - 2);
            }
        }
        
    }
}
