using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaLib;

namespace CalcTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator calc1 = new AreaCalculator();
            double[] values = {3,4,5};
            Circle_D circle_d = new Circle_D();
            calc1.AddShape(circle_d);
            Console.WriteLine(calc1.Calculate("triangle_3s", values));
            Console.WriteLine(calc1.Calculate("circle", values));
            Console.WriteLine(calc1.Calculate("circle_d", values));
            Console.ReadKey();
        }
    }
}
