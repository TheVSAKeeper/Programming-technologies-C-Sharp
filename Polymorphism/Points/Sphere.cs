using System;

namespace Polymorphism.Points
{
    internal class Sphere : Circle
    {
        public Sphere(double x, double y, double r) : base(x, y)
        {
            Radius = r;
        }

        public Sphere()
        {
        }

        public virtual double Volume() => Square() * Radius * (4 / 3.0);

        public virtual double SurfaceArea() => Square() * 4;

        public override string GetDescription() => $"{base.GetDescription()}{Environment.NewLine}" +
                                                   $"Объем сферы: {Volume():F3}{Environment.NewLine}" +
                                                   $"Площадь поверхности сферы: {SurfaceArea():F3}";
    }
}