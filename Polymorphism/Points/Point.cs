namespace Polymorphism.Points
{
    internal class Point
    {
        protected double X;
        protected double Y;

        public double PointX
        {
            get => X;
            set => X = value;
        }

        public double PointY
        {
            get => Y;
            set => Y = value;
        }

        public virtual string GetDescription() => $"X: {PointX} Y: {PointY}";
    }
}