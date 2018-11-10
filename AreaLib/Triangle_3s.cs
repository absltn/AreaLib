using System;

namespace AreaLib
{
    // triangle shape to calculate area with given 3 sides
    public class Triangle_3s : Shape
    {
        public Triangle_3s()
        {
            Name = "triangle_3s";
            Properties = 3;
        }

        public bool isRightTriangle(double[] values)
        {
            double a = values[0];
            double b = values[1];
            double c = values[2];
            if (!(((a + b) > c) && ((b + c) > a) && ((c + a) > b)))
                throw new ArgumentException("This is not a valid triangle");

            if ((a * a + b * b == c * c) || (b * b + c * c == a * a)
                    || (c * c + b * b == a * a))
            {
                return true;
            }
                
            else
            {
                return false;
            } 
        }
        public override double CalculateArea(double[] values)
        {

            double a = values[0];
            double b = values[1];
            double c = values[2];

            // check if triangle exists
            if (!(((a + b) > c) && ((b + c) > a) && ((c + a) > b)))
                throw new ArgumentException("This is not a valid triangle");

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
