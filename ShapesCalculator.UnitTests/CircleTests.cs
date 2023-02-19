using ShapesCalculator.Shapes;

namespace ShapesCalculator.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void Test1()
        {
            var figure = new Circle(3);
            var area = figure.CalculateArea();

            Assert.Equal(28.2743, Math.Round(area, 4));
        }
    }
}