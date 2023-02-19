using ShapesCalculator.Shapes;

namespace ShapesCalculator.UnitTests
{
    public class SquareTests
    {
        [Fact]
        public void Test1()
        {
            var figure = new Rectangle(10, 20);
            var area = figure.CalculateArea();

            Assert.Equal(200, area);
        }

        [Fact]
        public void Test2()
        {
            var figure = new Rectangle(10, 30);
            var area = figure.CalculateArea();

            Assert.Equal(300, area);
        }

        [Fact]
        public void Test3()
        {
            var figure = new Rectangle(5, 4);
            var area = figure.CalculateArea();

            Assert.Equal(20, area);
        }

        [Fact]
        public void Test4()
        {
            var figure = new Rectangle(2, 0.5);
            var area = figure.CalculateArea();

            Assert.Equal(1, area);
        }
    }
}