using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry3
{
    public abstract class Triangle
    {
        public double Side1 { get; private set; } = 0.0;
        public double Side2 { get; private set; } = 0.0;
        public double Angle { get; private set; } = 0.0;

        public Triangle(double side1, double side2, double angle)
        {
            Side1 = side1;
            Side2 = side2;
            Angle = angle;

        }

        public abstract double Perimeter();
        public abstract double Area();
    }
}
