using AreaLib;

namespace CalcTest
{
    class Circle_D : Shape
    {
        public Circle_D()
        {
            Name = "circle_d";
            Properties = 1;
        }
        public override double CalculateArea(double[] values)
        {
            return values[0] * values[0] * pi / 4;
        }
    }
}
