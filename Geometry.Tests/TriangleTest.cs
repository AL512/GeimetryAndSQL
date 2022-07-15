using Geometry.Figures;
using System;
using Xunit;

namespace Geometry.Tests
{
    /// <summary>
    /// Тесты класса Triangle
    /// </summary>
    public class TriangleTest
    {
        /// <summary>
        /// Тест свойств при создании
        /// </summary>
        [Fact]
        public void ConstrTest()
        {
            string name = "Triangle 1";
            double a = 10;
            double b = 20;
            double c = 25;

            Triangle triangle = new(name, a, b, c);

            Assert.Equal(10, triangle.A);
            Assert.Equal(20, triangle.B);
            Assert.Equal(25, triangle.C);
        }
        /// <summary>
        /// Тест задания стороны А, B и C
        /// </summary>
        [Fact]
        public void ABCTest()
        {
            string name = "Triangle 48";
            double a = 10.1;
            double b = 20.2;
            double c = 17.3;

            Triangle triangle = new(name, a, b, c);

            Assert.Equal(10.1, triangle.A);
            Assert.Equal(20.2, triangle.B);
            Assert.Equal(17.3, triangle.C);
        }
        /// <summary>
        /// Тест задания стороны А с исключением
        /// </summary>
        [Fact]
        public void AExTest()
        {
            string name = "Triangle 1";
            double a = 10.1;
            double b = 20.2;
            double c = 30.3;

            Triangle triangle = new(name, a, b, c);

            Assert.Throws<Exception>(() => triangle.A = -10.1);
        }
        /// <summary>
        /// Тест задания стороны В с исключением
        /// </summary>
        [Fact]
        public void BExTest()
        {
            string name = "Triangle 1";
            double a = 10.1;
            double b = 20.2;
            double c = 30.3;

            Triangle triangle = new(name, a, b, c);

            Assert.Throws<Exception>(() => triangle.B = -20.2);
        }
        /// <summary>
        /// Тест задания стороны С с исключением
        /// </summary>
        [Fact]
        public void CExTest()
        {
            string name = "Triangle 1";
            double a = 10.1;
            double b = 20.2;
            double c = 30.3;

            Triangle triangle = new(name, a, b, c);

            Assert.Throws<Exception>(() => triangle.C = -30.3);
        }
        /// <summary>
        /// Тест свойств при создании с исключением 
        /// (одна из сторон меньше 0)
        /// </summary>
        [Fact]
        public void ConstrExMinusTest()
        {
            string name = "Triangle 1";
            double a = 10.1;
            double b = 20.2;
            double c = -15.3;

            Assert.Throws<Exception>(() => new Triangle(name, a, b, c));
        }
        /// <summary>
        /// Тест проверки на существования треугольника
        /// </summary>
        [Fact]
        public void CheckTrueTest()
        {
            double a = 12.5;
            double b = 10.35;
            double c = 17;

            Assert.True(Triangle.Check(a, b, c));
        }
        /// <summary>
        /// Тест проверки на существования треугольника с исключением
        /// (стоона больше суммы двух других)
        /// </summary>
        [Fact]
        public void CheckFalseSumTest()
        {
            double a = 12.5;
            double b = 21.35;
            double c = 7;

            Assert.False(Triangle.Check(a, b, c));
        }
        /// <summary>
        /// Тест проверки на существования треугольника с исключением
        /// (стоона больше суммы двух других)
        /// </summary>
        [Fact]
        public void CheckFalseMinusTest()
        {
            double a = -12.5;
            double b = 14.35;
            double c = -7;

            Assert.False(Triangle.Check(a, b, c));
        }
        /// <summary>
        /// Тест имени треугольника
        /// </summary>
        [Fact]
        public void NameTest()
        {
            string name = "SimplName";
            double a = 10;
            double b = 20;
            double c = 25;

            Triangle triangle = new(name, a, b, c);

            Assert.Equal("SimplName", triangle.Name);
        }
        /// <summary>
        /// Тест имени окружности с исключением
        /// </summary>
        [Fact]
        public void NameNullTest()
        {
            string name = null;
            double a = 10;
            double b = 20;
            double c = 25;

            Triangle triangle = new(name, a, b, c);

            Assert.Equal($"Figure {DateTime.Now.ToString("ddMMYYYHHmmss")}", triangle.Name);
        }
        /// <summary>
        /// Тест проверки является ли треугольник прямоугольным
        /// (прямоугольный)
        /// </summary>
        [Fact]
        public void IsStraightTrueTest()
        {
            string name = "Triangle 1";
            double a = 12;
            double b = 13;
            double c = 5;
            Triangle triangle = new(name, a, b, c);

            Assert.True(triangle.IsStraight());
        }
        /// <summary>
        /// Тест проверки является ли треугольник прямоугольным
        /// (не прямоугольный)
        /// </summary>
        [Fact]
        public void IsStraightFalseTest()
        {
            string name = "Triangle 1";
            double a = 12.3;
            double b = 20.5;
            double c = 17;

            Triangle triangle = new(name, a, b, c);

            Assert.False(triangle.IsStraight());
        }
        /// <summary>
        /// Тест проверки является ли треугольник прямоугольным
        /// с исключением
        /// </summary>
        [Fact]
        public void IsStraightExTest()
        {
            string name = "Triangle 1";
            double a = 12;
            double b = 13;
            double c = 27;

            Triangle triangle = new(name, a, b, c);

            Assert.Throws<Exception>(() => triangle.IsStraight());
        }
        /// <summary>
        /// Тест вычисления площади треугольника
        /// </summary>
        [Fact]
        public void CalcSquareTest()
        {
            string name = "Triangle 1";
            double a = 10.0;
            double b = 20.5;
            double c = 25.1;

            Triangle triangle = new(name, a, b, c);

            Assert.Equal(98.76, triangle.CalcSquare());
        }
        /// <summary>
        /// Тест вычисления площади треугольника с точностью 9 знаков
        /// </summary>
        [Fact]
        public void CalcSquareDigits9Test()
        {
            string name = "Triangle 1";
            double a = 10;
            double b = 20;
            double c = 25;

            Triangle triangle = new(name, a, b, c);

            Assert.Equal(94.99177596, triangle.CalcSquare(9));
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

            Assert.Throws<Exception>(() => triangle.CalcSquare());
        }
    }
}
