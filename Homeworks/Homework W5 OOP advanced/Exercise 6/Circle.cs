using System;
namespace Homework_W5_OOP_advanced.Exercise6
{
	public class CircleEx6: IShape, Icolor
	{
        public double radius;
        private double Radius { get {return this.radius; } set {this.radius=value; } }
        public double Area { get; set; }
        string Icolor.Color { get { return this.color; } set { this.color = value; } }
        public string color;
        public CircleEx6(double radius)
		{
            this.radius = radius;
            this.color = "Black";
		}

        public CircleEx6(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double CalculateArea()
        {
            return Area = Math.PI * Math.Pow(Radius, 2);
        }

        public string CalculateArea(string unit)
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            string message = $"The Area is {Area} {unit}";
            return message;
        }
    }
}

