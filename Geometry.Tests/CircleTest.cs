using Geometry.Figures;
using System;
using Xunit;

namespace Geometry.Tests
{
    /// <summary>
    /// Тесты класса Circle
    /// </summary>
    public class CircleTest
    {
        /// <summary>
        /// Тест радиусу окружности при создании
        /// </summary>
        [Fact]
        public void ConstrRadiusTest()
        {
            string name = "Circle 1";
            double radius = 10;

            Circle circle = new(name, radius);

            Assert.Equal(10, circle.Radius);
        }
        /// <summary>
        /// Тест радиусу окружности при создании с исключением
        /// </summary>
        [Fact]
        public void ConstrRadiusExTest()
        {
            string name = "Circle 1";
            double radius = -2;

            Assert.Throws<Exception>(() => new Circle(name, radius));

        }
        /// <summary>
        /// Тест радиусу окружности
        /// </summary>
        [Fact]
        public void RadiusTest()
        {
            string name = "Circle 1";
            double radius = 10;

            Circle circle = new(name, radius);
            circle.Radius = 7;

            Assert.Equal(7, circle.Radius);
        }
        /// <summary>
        /// Тест радиусу окружности с исключением
        /// </summary>
        [Fact]
        public void RadiusExTest()
        {
            string name = "Circle 1";
            double radius = 15;
            Circle circle = new(name, radius);

            Assert.Throws<Exception>(() => circle.Radius = -20);

        }
        /// <summary>
        /// Тест имени окружности
        /// </summary>
        [Fact]
        public void NameTest()
        {
            string name = "Circle 1";
            double radius = 15;
            Circle circle = new(name, radius);

            Assert.Equal("Circle 1", circle.Name);
        }
        /// <summary>
        /// Тест имени окружности с исключением
        /// </summary>
        [Fact]
        public void NameNullTest()
        {
            string name = null;
            double radius = 15;
            Circle circle = new(name, radius);

            Assert.Equal($"Figure {DateTime.Now.ToString("ddMMYYYHHmmss")}", circle.Name);
        }
        /// <summary>
        /// Тест вычисления площади окружности по умолчанию
        /// </summary>
        [Fact]
        public void SquareTest()
        {
            string name = "Circle 1";
            double radius = 3.5;
            Circle circle = new(name, radius);

            Assert.Equal(38.48, circle.CalcSquare());
        }
        /// <summary>
        /// Тест вычисления площади окружности с точностью 5 знаков
        /// </summary>
        [Fact]
        public void SquareDigits5Test()
        {
            string name = "Circle 1";
            double radius = 13.2;
            Circle circle = new(name, radius);

            Assert.Equal(547.3911, circle.CalcSquare(5));
        }
    }
}