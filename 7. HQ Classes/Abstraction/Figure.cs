using System;

namespace Abstraction
{
    abstract class Figure
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double Radius { get; set; }

        protected Figure()
        {
        }

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalcPerimeter();
        public abstract double CalcSurface();

    }
}
