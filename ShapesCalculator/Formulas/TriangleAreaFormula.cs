namespace ShapesCalculator.Formulas;
/// <summary>
/// Формула для рассчёта площади треуголника
/// </summary>
public class TriangleAreaFormula : Formula
{
    /// <summary>
    /// Рассчитать площадь треугольника
    /// </summary>
    /// <typeparam name="TShape"></typeparam>
    /// <param name="shape"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public override double CalculateArea<TShape>(TShape shape)
    {
        if (shape is Triangle triangle)
        {
            // Находим полупериметр треугольника
            // для дальнейшего вычисления по формуле
            double p = (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide) / 2;
            // Находим площадь треугольника
            double s = Math.Sqrt(p * 
                (p - triangle.FirstSide) * 
                (p - triangle.SecondSide) * 
                (p - triangle.ThirdSide));

            return s;
        }

        throw new Exception("Эта формула не подходит к данной фигуре");
    }
}
