using System;
namespace Homework_W5_OOP_advanced.Exercise3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get; set; } = 0;
        public double Perimeter { get; set; }

        public abstract double CalculateArea();

        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public virtual string GetPerimeter(string input)
        {
            string message = ($" The perimeter is {Perimeter} {input} ");
            return message;
        }
    }
}

