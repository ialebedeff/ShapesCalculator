namespace ShapesCalculator.Formulas;
/// <summary>
/// Формула
/// </summary>
public abstract class Formula
{
    /// <summary>
    /// Рассчитать площадь по формуле
    /// </summary>
    /// <param name="shape"></param>
    /// <returns></returns>
    public abstract double CalculateArea<TShape>(TShape shape)
        where TShape : Shape;
}