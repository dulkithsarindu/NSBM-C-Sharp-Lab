using System;

namespace q3
{
    class TemperatureTracker
    {
        public int[] dtemperature;

        public TemperatureTracker()
        {
            dtemperature = new int[7];
        }

        public void GetTemperature()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter day {i + 1} temperature");
                dtemperature[i] = int.Parse(Console.ReadLine());
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tmpreport = new TemperatureTracker();

            tmpreport.GetTemperature();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Temperature of day {i + 1} is {tmpreport.dtemperature[i]}");
            }
            Console.ReadLine();
        }
    }
}