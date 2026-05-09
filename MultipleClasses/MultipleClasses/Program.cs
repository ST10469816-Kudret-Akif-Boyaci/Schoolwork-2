using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //StudentManager manager = new StudentManager();

            //manager addstudent(student("thabo", 12345, 75));
            //manager addstudent(NewsStyleUriParser student("alice", 22345, 60));
            //manager addstudent(NewsStyleUriParser student("thabo", 32345, 55));

            //Console.WriteLine("studen list: ");

            //foreach (var student1 in manager.getallstudents())
            //{
            //    Console.WriteLine(student1.getdetails());

            //}
            //Console.WriteLine("\n Average mark : " + manager.GetAvarageMark());

            //Console.ReadLine();


            // ask for 2 numbers from console terminal
            Console.WriteLine("enter the first number");
            int number1 = int .Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            //perform math operations
            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number2 * number1;
            double quotient = (double)number1 / number2;  //cast to duble for demial


            //display the results
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"difference: {difference}");
            Console.WriteLine($"product: {product}");
            Console.WriteLine($"quotient: {quotient}");

            Console.ReadLine();


            Triangle.triangleshape triangleshape1 = new Triangle.triangleshape();
            Rectangle.Rectangleshape rectangleshape2 = new Rectangle.Rectangleshape();

            double areatriangle = triangleshape1.trianglearea();
            double arearectangle = rectangleshape2.rectanglearea();

            Console.WriteLine("area of blue triangle is  " + areatriangle);
            Console.WriteLine("area of orange triangle is the same as the blue triangle" + areatriangle);
            Console.WriteLine("area of rectangle is " + arearectangle);

            double sumoftriangles = 2 * areatriangle;

            //confirm the results if 2 triangles are equal

            Console.WriteLine($"area of both triangles {sumoftriangles} = {arearectangle}");

            Console.ReadLine() ;

        }
    }
}
