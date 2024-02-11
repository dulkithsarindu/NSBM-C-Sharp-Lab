using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number we want to find the sum of all numbers until");
            int num = int.Parse(Console.ReadLine());

            int tot = 0;
            for (int i = 1; i<=num; i++)
            {
                tot = tot + i;
            }

            Console.WriteLine($"Sum is {tot}");
            Console.ReadLine();
        }
    }
}
