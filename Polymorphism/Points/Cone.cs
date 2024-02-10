using System;

namespace Polymorphism.Points
{
    internal class Cone : Circle
    {
        private double _height;

        public Cone(double x, double y, double r) : base(x, y)
        {
            Radius = r;
        }

        public Cone()
        {
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value > 0)
                    _height = value;
            }
        }

        private double SquareSide() => Math.PI * Radius * Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(_height, 2));

        public virtual double Volume() => Square() * _height * (1.0 / 3);

        public virtual double SurfaceArea() => Square() + SquareSide();

        public override string GetDescription() => $"{base.GetDescription()}{Environment.NewLine}" +
                                                   $"Объем конуса: {Volume():F3}{Environment.NewLine}" +
                                                   $"Площадь поверхности конуса: {SurfaceArea():F3}";
    }
}