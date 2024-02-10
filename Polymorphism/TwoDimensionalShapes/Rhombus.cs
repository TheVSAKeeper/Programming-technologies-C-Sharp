using System;

namespace Polymorphism.TwoDimensionalShapes
{
    internal class Rhombus : Square
    {
        public Rhombus((double, double) diagonals) : base(ConvertToSide(diagonals))
        {
            FirstDiagonal = diagonals.Item1 < 0 ? 0 : diagonals.Item1;
            SecondDiagonal = diagonals.Item2 < 0 ? 0 : diagonals.Item2;
        }

        private double FirstDiagonal { get; }
        private double SecondDiagonal { get; }

        protected override double Area => FirstDiagonal * SecondDiagonal / 2;

        private static double ConvertToSide((double, double) diagonals) => Math.Sqrt((diagonals.Item1 * diagonals.Item1 + diagonals.Item2 * diagonals.Item2) / 4);

        public override string GetDescription() => $"Длина первой диагонали: {FirstDiagonal}{Environment.NewLine}" +
                                                   $"Длина второй диагонали: {SecondDiagonal}{Environment.NewLine}" +
                                                   $"{base.GetDescription()}";
    }
}