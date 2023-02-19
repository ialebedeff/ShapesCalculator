using ShapesCalculator.Shapes;
using System.Drawing;
using System.Security.Principal;

namespace ShapesCalculator.UnitTests
{
    public class CustomTests
    {
        [Fact]
        public void Test1()
        {
            // Создаём прямоугольник
            var rectangle = new CustomShape(areaFormula =>
            areaFormula.Sides[0] *
            areaFormula.Sides[1],
            1, 2);

            var area = rectangle.CalculateArea();
            Assert.Equal(2, area);
        }

        [Fact]
        public void Test2()
        {
            // Создаем круг
            var circle = new CustomShape(
                areaFormula =>
                {
                    return Math.Pow(areaFormula.Sides[0], 2) * Math.PI;
                }, 
                sides: 3);

            var area = circle.CalculateArea();

            Assert.Equal(28.2743, Math.Round(area, 4));
        }
    }
    public class TrianglesTests
    {
        [Fact]
        public void Test1()
        {
            var figure = new Triangle(1, 2, 3);
            var area = figure.CalculateArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void Test2()
        {
            var figure = new Triangle(2, 4, 6);
            var area = figure.CalculateArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void Test3()
        {
            var figure = new Triangle(4, 4, 8);
            var area = figure.CalculateArea();

            Assert.Equal(0, area);
        }

        [Fact]
        public void Test4()
        {
            var figure = new Triangle(5, 5, 3);
            var area = figure.CalculateArea();

            Assert.Equal(7.1545, Math.Round(area, 4));
        }
    }
}