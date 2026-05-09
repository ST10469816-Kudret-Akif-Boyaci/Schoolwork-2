using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class calculator
 {
        public double add(double a, double b)
        {
            return a + b; }

        public double substract(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("cant divide by zero");
                return a + b;
        }
    }
}
