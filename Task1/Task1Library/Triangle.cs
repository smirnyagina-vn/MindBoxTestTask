using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Library
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRightAngled { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Каждая сторона должна быть больше нуля");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Невалидный треугольник");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRightAngled = CalculateIsRightAngled();
        }

        public double CalculateArea()
        {
            return IsRightAngled ? RightTriangleArea() : NotRightTriangleArea();
        }

        private double NotRightTriangleArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        private double RightTriangleArea()
        {
            if (SideA * SideA == SideB * SideB + SideC * SideC)
                return (SideB * SideC) / 2;
            else if (SideB * SideB == SideA * SideA + SideC * SideC)
                return (SideA * SideC) / 2;
            else
                return (SideA * SideB) / 2;
        }

        private bool CalculateIsRightAngled()
        {
            return (SideA * SideA != double.PositiveInfinity &&
                    SideB * SideB != double.PositiveInfinity &&
                    SideC * SideC != double.PositiveInfinity) &&
                   (SideA * SideA == SideB * SideB + SideC * SideC ||
                    SideB * SideB == SideA * SideA + SideC * SideC ||
                    SideC * SideC == SideA * SideA + SideB * SideB);
        }
    }
}
