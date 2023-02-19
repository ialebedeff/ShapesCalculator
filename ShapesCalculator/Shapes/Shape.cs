namespace ShapesCalculator.Shapes
{
    /// <summary>
    /// Фигура
    /// </summary>
    public class Shape
    {
        public Shape() { }
        /// <summary>
        /// Формула для рассчёта площади фигуры
        /// </summary>
        public Formula Formula { get; set; } = null!;
        /// <summary>
        /// Рассчитать площадь фигуры
        /// </summary>
        /// <returns></returns>
        public double CalculateArea() => Formula.CalculateArea(this);
    }
}