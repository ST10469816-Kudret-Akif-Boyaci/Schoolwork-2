using System.Diagnostics;

namespace Inheritance_Polymorphism
{

    //inheritance - the ability to derive from another class
    //at least two classes for inheritance: Base class and derived class
    //Child class -> inherit al the characteristics from parent class
    //Declare variables within the parent classes private -> access these variables in the child? no
    //Declare variables as internal  withing parent class -> access these variables in the child? yes
    //Declare variables as protected withing parent class -> access these variables in the child? yes

    public class mybase      //parent class
    {
        protected int number = 10;
    }

    public class myderived : mybase              //child class -> colon (:) is used to dxeclare inharitance
    {
        public void method_name()
        {
            Console.WriteLine(number);
        }
    }





    //generalize information in the base class
    public class person
    {
        public string name {  get; set; }
        public int age { get; set; }

       // initialize information
       public person(string name1,int age1)
        {
            name = name1;
            age = age1;
        }

        public virtual void displayinfo()   // define the generic functionality as a virtual method
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    //generc information will then be used by the derived class

    public class student : person
    {
        public int grade { get; set; } //one variable to make this class unique

        public student (string name1, int age1, int grade1): base(name1, age1)
        {
            grade = grade1;
        }

        //visualize info about the student
        public override void displayinfo()
        {
            Console.WriteLine($"name: {name}, Age: {age}, Grade: {grade}");
        }
    }


    //second derived class inheritiung from person class

    public class teacher: person
    {
        //make this class unique with a new variable
        public string subject { get; set; }

        public teacher(string name1, int age1, string subject1) : base(name1, age1)
        {
            subject = subject1;
        }

        public override void displayinfo()
        {
            Console.WriteLine($"name: {name}, Age: {age}, subject: {subject}");
        }
    }


    //base class - shape to generalize information about the shape

    public class shape
    {
        protected int radius;
        protected int heighttriange;
        protected int basetriange;

        protected int heightparallelogram;
        protected int baseparallelogram;
        protected int pi;

        //properties: getter and setters
        //two types of properties: Automatic properties and custom properties

        public int number { get; set; } // automatic properties

        //custom properties - take the format of a method to set and get values
        public void setradius(int r)
        {
            radius = r;
        }

        public void setbasetriange(int b)
        {
            basetriange = b;
        }

        public void setheighttriange(int h)
        {
            heighttriange = h;
        }

        public void setheightparallelogram(int h)
        {
            heightparallelogram = h;
        }

        public void setbaseparallelogram(int b)
        {
            baseparallelogram = b;
        }
    }

    //create derived class -> circle, triange, parallelogram
    public class triange: shape
    {
        public double getareatriangel() //a custom getter property
        {
            return(0.5 * basetriange * heighttriange);
        }
    }

    public class circle : shape
    {
        public double getareacircle() //a custom getter property
        {
            double pi = 3.14F;
            return (pi * radius * radius);
        }
    }


    public class parallelogram : shape
    {
        public double getareaparallelogram() //a custom getter property
        {
            double pi = 3.14F;
            return ( baseparallelogram * heightparallelogram);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            student student1 = new student("vuyo", 19, 42);
            student1.displayinfo();

            //info about teacher
            teacher teacher1 = new teacher("mpho", 89, "prog6221");
            teacher1.displayinfo();


            //circle are calculation
            circle circle1 = new circle();
            circle1.setradius(10);
            Console.WriteLine(circle1.getareacircle());

            //triangle are calculation
            triange triange1 = new triange();
            triange1.setbasetriange(8);
            triange1.setheighttriange(10);
            Console.WriteLine(triange1.getareatriangel);

            //parallelogram are calculation
            parallelogram parallelogram1 = new parallelogram();
            parallelogram1.setheightparallelogram(20);
            parallelogram1.setbaseparallelogram(30);
            Console.WriteLine(parallelogram1.getareaparallelogram);
        }
    }
}
