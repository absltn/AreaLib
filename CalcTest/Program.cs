using System;
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
            Circle c2 = new Circle();
            calc1.AddShape(c2);
            calc1.AddShape(circle_d);
            Console.WriteLine(calc1.ToString());
            Console.WriteLine(calc1.Calculate("triangle_3s", values));
            Console.WriteLine(calc1.Calculate("circle", values));
            Console.WriteLine(calc1.Calculate("circle_d", values));
            Console.ReadKey();
        }
    }
}
