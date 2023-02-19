namespace ShapesCalculator.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="Exception">Если любая из сторон меньше или равна Нулю</exception>
        public Triangle(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            if (firstSide <= 0 ||
                secondSide <= 0 ||
                thirdSide <= 0)
            {
                throw new Exception("Стороны фигуры не могут быть отрицательными");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            Formula = new TriangleAreaFormula();
        }

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; set; }
        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; set; }
        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; set; }
        /// <summary>
        /// Проверка на: Треугольник является прямоугольным
        /// </summary>
        public bool IsRectangular => 
            // Вместо Math.Pow лучше просто
            // умножить число само на себя
            // Но т.к это тестовое, я
            // сократил количество строк
            // для удобства чтения
            Math.Pow(FirstSide, 2) + 
            Math.Pow(SecondSide, 2) == 
            Math.Pow(ThirdSide, 2);
    }
}