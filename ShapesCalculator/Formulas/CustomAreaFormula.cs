namespace ShapesCalculator.Formulas;

/// <summary>
/// Кастомная формула для рассчёта кастомной фигура.
/// Вычисление площади фигуры без знания типа фигуры в compile-time
/// </summary>
public class CustomAreaFormula : Formula
{
    private readonly Func<CustomShape, double> _formula;
    /// <summary>
    /// Кастомная формула:
    /// Вычисление площади фигуры без знания типа фигуры в compile-time
    /// </summary>
    /// <param name="formula"></param>
    public CustomAreaFormula(Func<CustomShape, double> formula)
    {
        _formula = formula;
    }

    /// <summary>
    /// Рассчитать площадь кастомной фигуры
    /// </summary>
    /// <typeparam name="TShape"></typeparam>
    /// <param name="shape"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public override double CalculateArea<TShape>(TShape shape)
    { 
        if (shape is CustomShape customShape)
        {
            return _formula.Invoke(customShape);
        }

        throw new Exception("Эта формула не подходит для данной фигуры.");
    } 
}