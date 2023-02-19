# ShapesCalculator

# Юнит-тесты => Лежат в проекте - ShapesCalculator.UnitTests
# Легкость добавления других фигур => Легко, создаются за 2 наносекунды, честно
# Вычисление площади фигуры без знания типа фигуры в compile-time

```
// Пишем вашу формула в areaFormula, 
// и закидываем в класс стороны размеры сторон.

var rectangle = new CustomShape(areaFormula =>
            areaFormula.Sides[0] *
            areaFormula.Sides[1],
            1, 2);

var area = rectangle.CalculateArea();
```

# Проверку на то, является ли треугольник прямоугольным 

```
var triangle = new Triangle(2, 2, 8);
var isRectangled = triangle.IsRectangled;
```

