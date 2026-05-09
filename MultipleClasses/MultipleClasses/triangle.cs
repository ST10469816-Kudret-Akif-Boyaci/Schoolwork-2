using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class triangleshape
    {

        public int Base;
        public int Height;

        public double trianglearea()
        {
            Console.WriteLine("enter your base: ");
            Base = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your Height: ");
            Height = int.Parse(Console.ReadLine());

            double area = 0.5 * Base * Height;

            return area;
        }
    }
}
