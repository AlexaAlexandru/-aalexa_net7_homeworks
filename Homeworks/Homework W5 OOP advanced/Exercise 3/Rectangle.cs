using System;
namespace Homework_W5_OOP_advanced.Exercise3
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, double width, double height)
        {
            this.Color = color;
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return Area = Width * Height;
        }

        public override double GetPerimeter()
        {
            return Perimeter = 2 * (Width + Height);
        }
    }
}

