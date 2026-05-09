using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{

    public class circle
    {
        public const double pi = 3.14;
        public static double area(double r)  // calculate area assume pi is 3
        {
            double circarea = pi * r * r;
            return circarea;
        }

        public static double circumference(double r) // calculate circumference assume pi is 3
        {
            double circum = pi * 2 * r;
            return circum;
        }
    }
}
