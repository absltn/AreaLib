using System;

namespace AreaLib
{
    public class Circle : Shape
    {
        // circle shape which to calculate area with given radius
        public Circle()
        {
                Name = "circle";
                Properties = 1;
        }
        public override double CalculateArea(double[] values)
        {
                return values[0] * values[0] * pi;
        }
    }
}
