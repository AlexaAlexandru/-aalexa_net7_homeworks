using System;
namespace Homework_W5_OOP_advanced.Exercise3
{
	public class Circle:Shape
	{
        public double Radius { get; set; }

        public Circle(string color, double radius)
        {
            this.Color = color;
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Area = Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return Perimeter = 2 * Math.PI * Radius;
        }
    }
}

