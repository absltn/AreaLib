using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaLib
{
    [Serializable] // to be implemented
    public class AreaCalculator
    {
        // Shapes is a list of all available shapes which can be
        // used to calculate area.
        // In case only arguments are known, are will be calculated
        // to the first found shape

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
        public bool AddShape(Shape f)
        {
            // shape is added if only it it not already in the list
            if (Shapes.Find(x => x.GetType().Equals(f.GetType())) == null)
            {
                Shapes.Add(f);
                return true;
            }
            return false;
        }

        public bool RemShape(string f)
        {
            if (Shapes.Find(x => x.Name.Equals(f)) == null)
            {
                return false;
            }
            Shapes.Remove(Shapes.Find(x => x.Name.Equals(f)));
            return true;
        }
        public double Calculate(String f, double[] values)
        {
            // check property value sign

            if (values.Any(x => x < 0))
            {
                throw new ArgumentException("only positive arguments must be used");
            }

            // check that there are enough values to calculate

            if ((values.Length < Shapes.Find(x => x.Name.Equals(f)).Properties) || (values == null))
            {
                throw new ArgumentException("not enough arguments");
            }
            return Shapes.Find(x => x.Name.Equals(f)).CalculateArea(values);
        }

        // searches for the first shape in Shapes List with the same parameter
        // quantity and returns its area
        public double Calculate(double[] values)
        {
            // check property value sign

            if (values.Any(x => x < 0))
            {
                throw new ArgumentException("only positive arguments must be used");
            }

            if (values.Length < 1)
            {
                throw new ArgumentException("not enough arguments");
            }
            else
                return Shapes.Find(x => x.Properties.Equals(values.Length)).CalculateArea(values);
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
