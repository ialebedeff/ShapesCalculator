using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCalculator.Shapes
{
    public class CustomShape : Shape
    {
        public CustomShape(Func<CustomShape, double> formula, params double[] sides)
        {
            Sides = sides;
            Formula = new CustomAreaFormula(formula);
        }

        public double[] Sides { get; set; }
    }
}
