using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using mathLibrary;

namespace Calculatormain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calculator calc = new calculator();
            advancedcalculator advancedcalculator = new advancedcalculator();   

            double num1 = 10;
            double num2 = 30;

            Console.WriteLine("addition: " + calc.add(num1, num2));
            Console.WriteLine("Substranction: " + calc.substract(num1, num2));
            Console.WriteLine("multiplication: " + calc.multiply(num1, num2));
            Console.WriteLine("division: " + calc.divide(num1, num2));

            Console.WriteLine("power: " + advancedcalculator.power(num1, num2));
            Console.WriteLine("sqare root: " + advancedcalculator.root(num2));

            Console.ReadLine(); 
        }
    }
}
