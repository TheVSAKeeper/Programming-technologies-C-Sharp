using System;
using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public class Cone : ISurfaceOfRevolution, IShape, IRound, IDescribing
    {
        public Cone(Point position, float radius, float height)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height));

            Position = position;
            Radius = radius;
            Height = height;
        }

        public Cone(float radius, float height) : this(new Point(0, 0), radius, height)
        {
        }

        private float Height { get; }

        private Point Position { get; }

        private float AreaOfLateralSurface => (float)(Math.PI * Radius * Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2)));

        public string Description => string.Join(Environment.NewLine,
            Position.Description,
            $"R: {Radius}",
            $"Высота: {Height}",
            $"Периметр основания: {Perimeter:F3}",
            $"Площадь основания: {Area:F3}",
            $"Площадь боковой поверхности: {AreaOfLateralSurface:F3}",
            $"Площадь поверхности конуса: {SurfaceArea:F3}",
            $"Объем конуса: {EnclosedVolume:F3}");

        public float Radius { get; }

        public float Perimeter => (float)(2 * Math.PI * Radius);

        public float Area => (float)(Math.PI * Radius * Radius);

        public float SurfaceArea => Area + AreaOfLateralSurface;

        public float EnclosedVolume => (float)(Area * Height * (1.0 / 3));
    }
}