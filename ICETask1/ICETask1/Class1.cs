using Geometry;
using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;
using Geometry;

namespace ICETask1
{
    public class program

    {
       public static void Main(string[] args) { 
        calculator math1 = new calculator();
        circle math2 = new circle();

            // ask user for the numbers to do perations with
            Console.WriteLine("enter first number");
          int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
          int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the radius of the circle");
            double r = double.Parse(Console.ReadLine());


            // call MathOperations and get and print +-/*
            Console.WriteLine("addition: " + calculator.add(a, b));
            Console.WriteLine("substraction: " + calculator.substract(a, b));
            Console.WriteLine("multiply: " + calculator.multiply(a, b));
            Console.WriteLine("divide: " + calculator.divide(a, b));

            //call geometry and print area and circumference
            Console.WriteLine("area of the circle: " + circle.area(r));
            Console.WriteLine("circumference of the circle: " + circle.circumference(r));



        }
    }
}
