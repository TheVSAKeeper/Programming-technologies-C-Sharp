namespace Polymorphism.TwoDimensionalShapes
{
    public abstract class TwoDimensionalShape
    {
        protected TwoDimensionalShape(double length, double width)
        {
            Length = length < 0 ? 0 : length;
            Width = width < 0 ? 0 : width;
        }

        protected double Length { get; }
        protected double Width { get; }
    }
}