using System;

namespace Polymorphism.Points
{
    internal class Circle : Point
    {
        private double _radius;

        public Circle(double x, double y)
        {
            X = x;
            Y = y;
        }

        protected Circle()
        {
        }

        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                    _radius = value;
            }
        }

        protected double Square() => Math.PI * _radius * _radius;

        public override string GetDescription() => $"{base.GetDescription()} R: {_radius}{Environment.NewLine}" +
                                                   $"Площадь основания: {Square():F3}";
    }
}