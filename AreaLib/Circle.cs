using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Circle: Shape
    {
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
