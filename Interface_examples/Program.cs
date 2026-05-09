using System.Drawing;
using static Interface_examples.circle;

namespace Interface_examples
{


    //interface - defines a contract with noi implementations
    //inherit from the interface as a base class to then implement the contract declarations
    //able to do multiple inheritance from multiple base classes 
    //applications of interface - use interface on sensitive data (banking etc)

    //same examle we did with inheritance last week - use interfaces to declare and also implement

    public interface Ishape//interface which is a contrack declaration on implementation
    {
        double calculatearea(); // implement this in derived classes, but not within the interface
    }

    //class between the interfae and the derived classes => abstract class
    //derived class will inherit from abstract class
    //abstract class -> derive from interface class

    public abstract class Shape : Ishape
    {
        public abstract double calculatearea();
    }

    //another ibterface for multiple iheritance of interfaces
    public interface Icolor
    {
       // public string color;
    }

    // circle shape - calculate the area : implementation of the  method declared in the interface

    public class circle : Shape, Icolor
    {
        private double radius;
        private string color = "red";

        public circle(double radius1)
        {
            radius = radius1;
        }

        // implementation of the method from the interface decleration

        public override double calculatearea()
        {
            return Math.PI * radius * radius;
        }

        //create an implementation of Icolor interface in here
        public string getcolor()
        {
            return color;
        }
    }
        //rectangle shape - calculate area : Implemetation of the method declarated in the interface

        public class rectangle : Shape, Icolor
        {
            private double lenght;
            private double width;
        private string color = "green";

            public rectangle(double lenght1, double width1)
            {
                lenght = lenght1;
                width = width1;
            }

            //implement the interface with calculated area

            public override double calculatearea()
            {
                return lenght * width;
            }
        //create an implementation of Icolor interface in here
        public string getcolor()
        {
            return color;
        }
    }
    // new class to use interfaces
    //demonstrate how interfaces allow different objects to be treated the same way

    public class shapeprinter
    {
        public static void printarea(Ishape shape)
        {
            Console.WriteLine("area: " + shape.calculatearea());
        }

        public static void printallareas(List <Ishape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine("area: " + shape.calculatearea());
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // to create objects of the derived classes - not of the interface
            // interface object with no implementation is not useful

            circle circle1 = new circle(5);
            rectangle rectangle1 = new rectangle(4, 6);

            //display the areas of each shape  using the calculated area
            Console.WriteLine("area of circle: " + circle1.calculatearea());
            Console.WriteLine("area of rectangle: " + rectangle1.calculatearea());

            //display the areas of each shape using the calculate area
            shapeprinter.printarea(circle1);
            shapeprinter.printarea(rectangle1);

            //demonstrate interface list
            List<Ishape> shapes = new List<Ishape>();
            shapes.Add(circle1);
            shapes.Add(rectangle1);

            Console.WriteLine("\n all shape areas: ");
            shapeprinter.printallareas(shapes);
        }
    }
}
