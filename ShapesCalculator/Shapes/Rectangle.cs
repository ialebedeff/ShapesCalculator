namespace ShapesCalculator.Shapes
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Квадрат
        /// </summary>
        /// <param name="leftSide">Левая сторона прямоугольника</param>
        /// <param name="topSide">Верхняя сторона прямоугольника</param>
        /// <exception cref="Exception">Если любая из сторон меньше или равна Нулю</exception>
        public Rectangle(double leftSide, double topSide)
        {
            if (leftSide <= 0 ||
                topSide <= 0)
            {
                throw new Exception("Стороны фигуры не могут быть отрицательными");
            }

            LeftSide = leftSide;
            TopSide = topSide;

            Formula = new RectangleAreaFormula();
        }
        /// <summary>
        /// Левая сторона 
        /// </summary>
        public double LeftSide { get; set; }
        /// <summary>
        /// Верхняя сторона
        /// </summary>
        public double TopSide { get; set; }
    }
}