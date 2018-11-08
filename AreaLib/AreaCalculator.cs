using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class AreaCalculator
    {
        private List <Shape> shapes;
        public AreaCalculator()
        {
            shapes = new List<Shape>();
            Circle circle = new Circle();
            Triangle_3s triangle_3s = new Triangle_3s();
            AddShape(circle);                                    // default shapes
            AddShape(triangle_3s);
        }
        public void AddShape(Shape f) {
            if (shapes.Find(x => x.Equals(f)) != null)
            {
                shapes.Add(f);
            }
        }
        public double Calculate(String f, double[] values)
        {
            // check property value sign

            if (values.Any(x => x<0))
                throw new ArgumentException("only positive arguments must be used");

            // check properties

            if (values.Length < shapes.Find(x => x.Name.Equals(f)).Properties)
                throw new ArgumentException("not enough arguments");
            return shapes.Find(x => x.Name.Equals(f)).CalculateArea(values); // find element in a list
        }
        
        public void ShowElements()
        {
            foreach (var item in shapes)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
