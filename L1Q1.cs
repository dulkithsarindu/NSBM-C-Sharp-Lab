using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of the rectangle");
            float lenght = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter width of the rectangle");
            float width = float.Parse(Console.ReadLine());

            float result = areaR(lenght, width);
            Console.WriteLine($"Area of the rectangle is {result}");
            Console.ReadLine();
        }

        static float areaR(float lenght, float width)
        {
            return lenght * width;
        }
    }
}
