using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangleshape
    {


        public int Base;
        public int Lenght;

        public double rectanglearea()
        {
            Console.WriteLine("enter your base: ");
            Base = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your lenght: ");
            Lenght = int.Parse(Console.ReadLine());

            double area = Base * Lenght;

            return area;
        }
    }
}
