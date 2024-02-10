using System;
using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public class Snowman : ISurfaceOfRevolution, IDescribing
    {
        public Snowman(Cone bucket, Sphere head, Sphere averageBody, Sphere lowerBody)
        {
            Bucket = bucket;
            Head = head;
            AverageBody = averageBody;
            LowerBody = lowerBody;
        }

        private Cone Bucket { get; }

        private Sphere Head { get; }

        private Sphere AverageBody { get; }

        private Sphere LowerBody { get; }

        public string Description => string.Join(Environment.NewLine,
            $"Объем снеговика: {EnclosedVolume}",
            $"Площадь поверхности снеговика: {SurfaceArea}");

        public float SurfaceArea => Bucket.SurfaceArea + Head.SurfaceArea + AverageBody.SurfaceArea + LowerBody.SurfaceArea;

        public float EnclosedVolume => Bucket.EnclosedVolume + Head.EnclosedVolume + AverageBody.EnclosedVolume + LowerBody.EnclosedVolume;
    }
}