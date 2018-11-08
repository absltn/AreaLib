﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Triangle_3s : Shape
    {
        public Triangle_3s()
        {
            Name = "triangle_3s";
            Properties = 3;            
        }
        public override double CalculateArea(double[] values)
        {
            double a = values[0];
            double b = values[1];
            double c = values[2];

            // check if triangle exists

            if (!(((a + b) > c) && ((b + c) > a) && ((c + a) > b)))
                throw new ArgumentException("this is not a valid triangle");

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}