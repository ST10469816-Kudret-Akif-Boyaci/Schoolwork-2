using System;
using System.Collections.Generic;
using System.Text;

namespace ICETask1
{
    public class calculator
    {

        // declare four methods for 4 math operations + - * /
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int substract(int a, int b)
        {
            return a - b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static double divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("cant divide by zero");
            }
            else
            {

                return (double)a / b;
            }
        }
    }


}
