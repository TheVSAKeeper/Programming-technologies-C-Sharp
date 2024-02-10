namespace Polymorphism.Points
{
    internal class Snowman
    {
        public Cone Bucket { get; } = new Cone();

        public Sphere Head { get; } = new Sphere();

        public Sphere AverageBody { get; } = new Sphere();

        public Sphere LowerBody { get; } = new Sphere();

        public double SurfaceArea => Bucket.SurfaceArea() + Head.SurfaceArea() + AverageBody.SurfaceArea() + LowerBody.SurfaceArea();

        public double Volume => Bucket.Volume() + Head.Volume() + AverageBody.Volume() + LowerBody.Volume();
    }
}