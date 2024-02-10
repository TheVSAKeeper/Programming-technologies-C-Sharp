using System;

namespace Polymorphism.TwoDimensionalShapes
{
    internal class Square : TwoDimensionalShape
    {
        public Square(double side) : base(side, side)
        {
        }

        private double Perimeter => Length * 4;

        protected virtual double Area => Length * Width;

        public virtual string GetDescription() => $"Длина стороны: {Length:F3}{Environment.NewLine}" +
                                                  $"Периметр: {Perimeter:F3}{Environment.NewLine}" +
                                                  $"Площадь: {Area:F3}";
    }
}