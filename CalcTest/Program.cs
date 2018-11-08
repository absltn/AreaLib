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
            double[] values = {2,4,5};
            Circle circle2 = new Circle();
            calc1.AddShape(circle2);
            //calc1.ShowElements();
            Console.WriteLine(calc1.Calculate("circle", values));
            Console.WriteLine(calc1.Calculate("triangle_3s", values));
            Console.ReadKey();
        }
    }
}
