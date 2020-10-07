using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry3
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double side1, double side2, double angle) : base(side1, side2, angle)
        {
        }

        public override double Area()
        {
            return Side1 * Side2 * Math.Sin(Angle) / 2;
        }

        public override double Perimeter()
        {
            double Side3;
            Side3 = Math.Sqrt(Side1 * Side1 + Side2 * Side2 - 2 * Side1 * Side2 * Math.Cos(Angle));
            return Side1 + Side2 + Side3;
        }
    }
}
