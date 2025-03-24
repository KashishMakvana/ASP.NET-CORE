﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface Shape
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double side);
    }
    class Lab2_P7 : Shape
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double side)
        {
            return side * side;
        }
    }
}
