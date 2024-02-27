using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    abstract class shape
    {
        public string shapeType;
        public double area;

        public abstract double CalculateArea();

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shapetype: {shapeType}");
            Console.WriteLine($"Area: {area}");
        }
    }
    class rectangle : shape
    {
        public double length;
        public double width;    
        public void setDimensions(double length, double width)
        {
            this.length = length;
            this.width = width; 
        }
        public override double CalculateArea()
        {
            area = length * width;
            return area;
        }
    }
    class circle : shape
    {
        public double radius;

        public void setDimensions(double radius)
        {
            this.radius = radius;   
        }
        public override double CalculateArea()
        {
            area = radius * radius * 3.14;
            return area;    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle = new rectangle();
            rectangle.setDimensions(5, 10);
            rectangle.CalculateArea();
            Console.WriteLine($"Area of rectangle: {rectangle.CalculateArea()}");

            circle circle = new circle();
            circle.setDimensions(5);
            circle.CalculateArea();
            Console.WriteLine($"Area of circle: {circle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}
