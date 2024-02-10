using System;
using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public class Rhombus : ITwoDimensionalShape, IDescribing
    {
        public Rhombus(float side, float angle)
        {
            if (side <= 0)
                throw new ArgumentOutOfRangeException(nameof(side));

            if (angle <= 0 || angle >= 180)
                throw new ArgumentOutOfRangeException(nameof(angle));

            Side = side;
            Angle = angle;
        }

        private float FirstDiagonal => (float)(2 * Side * Math.Sin(Angle / 2 * Math.PI / 180));
        private float SecondDiagonal => (float)(2 * Side * Math.Cos(Angle / 2 * Math.PI / 180));
        private float Side { get; }
        private float Angle { get; }

        public string Description => string.Join(Environment.NewLine,
            $"Длина стороны: {Side:F3}",
            $"Длина первой диагонали: {FirstDiagonal:F3}",
            $"Длина второй диагонали: {SecondDiagonal:F3}",
            $"Периметр: {Perimeter:F3}",
            $"Площадь: {Area:F3}");

        public float Perimeter => Side * 4;

        public float Area => FirstDiagonal * SecondDiagonal / 2;
    }
}