using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_and_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] num = new int[10];
            string[] result = new string[10];
            for ( i = 0; i<10;  i++)
            {

                Console.WriteLine($"Enter number {i+1} to check odd or even");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] % 2 == 0)
                {
                    result[i] = "even";
                }
                else
                {
                    result[i] = "odd";
                }
            }
            for ( i = 0; i<10; i++)
            {
                Console.WriteLine($"{num[i]} is {result[i]}");

            }
            Console.ReadLine();

        }
    }
}
