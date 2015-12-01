using System;

namespace Shapes
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double widht, double height)
            : base(widht, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return Math.Sqrt(this.CalculateArea()) * 4;
        }
    }
}
