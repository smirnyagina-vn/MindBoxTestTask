using Task1Library;

namespace Task1Facts
{
    public class CircleFacts
    {
        private const double DEFAULT_TOLERANCE = 0.00001;

        [Fact]
        public void ConstructorValidRadius()
        {
            var circle = new Circle(5);
            Assert.Equal(5, circle.Radius);
        }

        [Fact]
        public void ConstructorNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void ConstructorZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(0.52121)]
        [InlineData(double.MaxValue)]
        public void AreaValidRadiusReturnsCorrectArea(double radius)
        {
            var circle = new Circle(radius);
            Assert.Equal(Math.PI * radius * radius, circle.CalculateArea(), DEFAULT_TOLERANCE);
        }
    }
}