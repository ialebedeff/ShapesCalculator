namespace ShapesCalculator.Formulas;
/// <summary>
/// Формула для рассчёта площади прямоуголника
/// </summary>
public class RectangleAreaFormula : Formula
{
    /// <summary>
    /// Рассчитать площадь прямоугольника
    /// </summary>
    /// <typeparam name="TShape"></typeparam>
    /// <param name="shape"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public override double CalculateArea<TShape>(TShape shape)
    {
        if (shape is Rectangle square)
        {
            return square.LeftSide * square.TopSide;
        }

        throw new Exception("Эта формула не подходит к данной фигуре");
    }
}