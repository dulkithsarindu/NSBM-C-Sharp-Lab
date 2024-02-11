using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace mtable
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number to get the multiplication table");
                int num = int.Parse(Console.ReadLine());

                int[,] nset = new int[num+1, num+1];

                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        nset[i, j] = i * j;
                    }
                }

                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        Console.WriteLine($"{i}*{j}={nset[i, j]}");
                    }
                }
                Console.ReadLine();
            }
        }
    }


