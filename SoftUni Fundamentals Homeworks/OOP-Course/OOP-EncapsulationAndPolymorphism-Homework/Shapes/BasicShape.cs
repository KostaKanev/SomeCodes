
namespace Shapes
{
    using Interfaces;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
