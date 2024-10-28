using System;
using Task1Library;

namespace Task1Facts
{
    public class TriangleFacts
    {
        private const double DEFAULT_TOLERANCE = 0.00001;

        [Theory]
        [InlineData(3, 4, 5)] //прямоугольный
        [InlineData(3, 5, 6)] //валидный
        [InlineData(5, 5, 5)] //равносторонний
        [InlineData(1, 2, 2)] //равнобедренный
        [InlineData(3.6, 4.8, 6.0)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)] //макс значения
        public void ConstructorValidSides(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.Equal(a, triangle.SideA);
            Assert.Equal(b, triangle.SideB);
            Assert.Equal(c, triangle.SideC);
        }

        [Theory]
        [InlineData(-1, 4, 5)]
        [InlineData(1, -4, 5)]
        [InlineData(1, 4, -5)]
        [InlineData(-1, -4, -5)]
        [InlineData(double.MinValue, double.MinValue, double.MinValue)]
        public void ConstructorNegativeSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(1, 0, 5)]
        [InlineData(1, 4, 0)]
        [InlineData(0, 0, 0)]
        public void ConstructorZeroSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 1, 2)]
        public void ConstructorInvalidTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5.625, 7.5, 9.375)]
        public void IsRightTrianglePositive(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.True(triangle.IsRightAngled);
        }

        [Theory]
        [InlineData(3, 5, 6)] //валидный
        [InlineData(5, 5, 5)] //равносторонний
        [InlineData(1, 2, 2)] //равнобедренный
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)] //макс значения
        public void IsRightTriangleNegative(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.False(triangle.IsRightAngled);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5.625, 7.5, 9.375, 21.09375)]
        public void RightTriangleCalculateArea(double a, double b, double c, double expextedResult)
        {
            var triangle = new Triangle(a, b, c);
            Assert.Equal(expextedResult, triangle.CalculateArea(), DEFAULT_TOLERANCE);
        }

        [Theory]
        [InlineData(3, 5, 6, 7.483315)] //валидный
        [InlineData(5, 5, 5, 10.825318)] //равносторонний
        [InlineData(1, 2, 2, 0.968246)] //равнобедренный
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue, double.PositiveInfinity)] //макс значения
        public void NonRightTriangleCalculateArea(double a, double b, double c, double expextedResult)
        {
            var triangle = new Triangle(a, b, c);
            Assert.Equal(expextedResult, triangle.CalculateArea(), DEFAULT_TOLERANCE);
        }
    }
}