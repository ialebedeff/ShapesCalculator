# ShapesCalculator

Юнит-тесты => Лежат в проекте ShapesCalculator.UnitTests 

Легкость добавления других фигур => Легко, создаются за 2 наносекунды, честно

# Вычисление площади фигуры без знания типа фигуры в compile-time

```
// Не совсем понял суть задания, но сделал как вижу
// Пишем вашу формулу сюда,
// и закидываем в класс стороны размеры сторон.

var rectangle = new CustomShape(shape =>
            shape.Sides[0] *
            shape.Sides[1],
            1, 2);

var area = rectangle.CalculateArea();
```

# Проверка на то, является ли треугольник прямоугольным 

```
var triangle = new Triangle(2, 2, 8);
var isRectangled = triangle.IsRectangled;
```

