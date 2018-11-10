using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaLib
{
    [Serializable] // to be implemented
    public class AreaCalculator
    {
        // list of all available shapes which can be used to calculate area
        private List<Shape> Shapes { get; set; }
        public AreaCalculator()
        {
            Shapes = new List<Shape>();

            // init and add default shapes

            Circle circle = new Circle();
            Triangle_3s triangle_3s = new Triangle_3s();
            AddShape(circle);                                    
            AddShape(triangle_3s);
        }
        public void AddShape(Shape f)
        {
            // shape is added if only it it not already in the list
            if (Shapes.Find(x => x.GetType().Equals(f.GetType())) == null)
            {
                Shapes.Add(f);
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

            if (values.Length < Shapes.Find(x => x.Name.Equals(f)).Properties)
            {
                throw new ArgumentException("not enough arguments");
            }
            return Shapes.Find(x => x.Name.Equals(f)).CalculateArea(values);
        }
        
        public override string ToString()
        {
            string result = "";
            foreach (var item in Shapes)
            {
                result += item.Name;
                result += ",";
                result += item.Properties;
                result += " ";
            }
            return result;     
        }
    }
}
