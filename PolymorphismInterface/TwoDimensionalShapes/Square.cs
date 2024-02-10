using System;
using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public class Square : ITwoDimensionalShape, IDescribing
    {
        public Square(float side)
        {
            if (side <= 0)
                throw new ArgumentOutOfRangeException(nameof(side));

            Side = side;
        }

        private float Side { get; }

        public string Description => string.Join(Environment.NewLine,
            $"Длина стороны: {Side:F3}",
            $"Периметр: {Perimeter:F3}",
            $"Площадь: {Area:F3}");

        public float Perimeter => Side * 4;

        public float Area => Side * Side;
    }
}