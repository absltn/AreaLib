using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaLib
{
    [Serializable] // to be implemented
    public class AreaCalculator
    {
        private List <Shape> shapes;
        public AreaCalculator()
        {
            shapes = new List<Shape>();

            // init and add default shapes

            Circle circle = new Circle();
            Triangle_3s triangle_3s = new Triangle_3s();
            AddShape(circle);                                    
            AddShape(triangle_3s);
        }
        public void AddShape(Shape f) {
            if (shapes.Find(x => x.Equals(f)) == null)
            {
                shapes.Add(f);
            }
        }
        public double Calculate(String f, double[] values)
        {
            // check property value sign

            if (values.Any(x => x < 0))
            {
                throw new ArgumentException("only positive arguments must be used");
            }

            // check that there are enough values to calculate

            if (values.Length < shapes.Find(x => x.Name.Equals(f)).Properties)
            {
                throw new ArgumentException("not enough arguments");
            }
            return shapes.Find(x => x.Name.Equals(f)).CalculateArea(values);
        }
        
        public void ShowElements()   // not implemented
        {
            foreach (var item in shapes)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
