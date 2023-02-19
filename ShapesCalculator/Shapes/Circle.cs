namespace ShapesCalculator.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="Exception">Если радиус меньше или равен Нулю</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть отрицательным");
            }

            Radius = radius;
            Formula = new CircleAreaFormula();
        }
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }
    }
}