namespace ShapesCalculator.Formulas;
/// <summary>
/// Формула для рассчёта площади круга
/// </summary>
public class CircleAreaFormula : Formula
{
    /// <summary>
    /// Рассчитать площадь круга
    /// </summary>
    /// <param name="shape"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public override double CalculateArea<TShape>(TShape shape)
    {
        if (shape is Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        throw new Exception("Эта формула не подходит к данной фигуре");
    }
}