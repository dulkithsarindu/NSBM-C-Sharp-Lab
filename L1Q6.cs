using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter number of subjects");
            int nsub = int.Parse(Console.ReadLine());

            string[] result = new string[nsub];

            for (int i = 0; i < nsub; i++)
            {
                Console.WriteLine($"Enter marks for the subject {i + 1}");
                int marks = int.Parse(Console.ReadLine());  

                if (marks > 100)
                {
                    result[i] = "Error";
                }
                else if (marks >= 75)
                {
                    result[i] = "A";
                }
                else if (marks >= 60)
                {
                    result[i] = "B";
                }
                else if (marks >= 50)
                {
                    result[i] = "C";
                }
                else if (marks >= 40)
                {
                    result[i] = "D";
                }
                else if (marks < 40)
                {
                    result[i] = "Fail";
                }
                else if (marks < 0)
                {
                    result[i] = "Error";
                }
            }
            for(int i = 0;i < nsub;i++)
            {
                Console.WriteLine($"Hi {name}");
                Console.WriteLine($"Grade for the subject {i+1} is {result[i]}");
            }
            Console.ReadLine();
        }
    }
}
