using System;
using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public class Sphere : ISurfaceOfRevolution, IShape, IRound, IDescribing
    {
        public Sphere(Point position, float radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Position = position;
            Radius = radius;
        }

        public Sphere(float radius) : this(new Point(0, 0), radius)
        {
        }

        private Point Position { get; }

        public string Description => string.Join(Environment.NewLine,
            Position.Description,
            $"R: {Radius}",
            $"Периметр: {Perimeter:F3}",
            $"Площадь: {Area:F3}",
            $"Площадь поверхности сферы: {SurfaceArea:F3}",
            $"Объем сферы: {EnclosedVolume:F3}");

        public float Radius { get; }

        public float Perimeter => (float)(2 * Math.PI * Radius);

        public float Area => (float)(Math.PI * Radius * Radius);

        public float SurfaceArea => Area * 4;

        public float EnclosedVolume => (float)(Area * Radius * (4 / 3.0));
    }
}