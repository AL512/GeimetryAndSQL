using Geometry.Figures;
using System;
using Xunit;

namespace Geometry.Tests
{
    /// <summary>
    /// Тесты класса FigureSquareTest
    /// </summary>
    public class FigureSquareTest
    {
        /// <summary>
        /// Тест вычисления площади треугольника с точностью 9 знаков
        /// </summary>
        [Fact]
        public void CalcSquareTest()
        {
            string name = "Triangle 1";
            double a = 10;
            double b = 20;
            double c = 25;

            Triangle triangle = new(name, a, b, c);
            Circle circle = new Circle(null, 20);

            Assert.Equal(94.99, FigureSquare.CalcSquare(triangle));
            Assert.Equal(1256.64, FigureSquare.CalcSquare(circle));
        }

        /// <summary>
        /// Тест вычисления площади треугольника с точностью 9 знаков
        /// </summary>
        [Fact]
        public void CalcSquare9Test()
        {
            string name = "Triangle 1";
            double a = 10;
            double b = 20;
            double c = 25;

            Triangle triangle = new(name, a, b, c);
            Circle circle = new Circle(null, 20);

            Assert.Equal(94.99177596, FigureSquare.CalcSquare(triangle, 9));
            Assert.Equal(1256.637061436, FigureSquare.CalcSquare(circle, 9));
        }
        /// <summary>
        /// Тест вычисления площади треугольника
        /// с исключением
        /// </summary>
        [Fact]
        public void CalcSquareExTest()
        {
            string name = "Triangle 1";
            double a = 1.0;
            double b = 8.5;
            double c = 2.1;

            Triangle triangle = new(name, a, b, c);
            Circle circle;

            Assert.Throws<Exception>(() => triangle.CalcSquare());
            Assert.Throws<Exception>(() => circle = new Circle(null, -2));
        }
    }
}
