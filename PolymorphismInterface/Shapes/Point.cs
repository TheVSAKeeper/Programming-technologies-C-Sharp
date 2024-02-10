using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public class Point : IPointing, IDescribing
    {
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public string Description => $"X:   {X}  Y:   {Y}";

        public float X { get; }

        public float Y { get; }
    }
}