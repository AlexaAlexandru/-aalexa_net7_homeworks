using System;
namespace Homework_W5_OOP_advanced.Exercise6
{
	public class RectangleEx6: IShape,Icolor
	{
        public double Width { get; set; }
        public double Height { get; set; }
        public string color;
        public double Area { get; set; }
        string Icolor.Color { get { return this.color; } set { this.color = value; } }

        public RectangleEx6( double width, double height)
		{
            this.Width = width;
            this.Height = height;
            this.color = "Black";
		}

        public RectangleEx6(double width, double height, string color)
        {
            this.Width = width;
            this.Height = height;
            this.color = color;
        }

        public double CalculateArea()
        {
            return Area = Width * Height;
        }

        public string CalculateArea(string unit)
        {
            Area = Width * Height;
            string message = $"The Area is {Area} {unit}";
            return message;
        }

        public string Color()
        {
            return color;
        }
    }
}

