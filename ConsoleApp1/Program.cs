using System.Linq.Expressions;

namespace ConsoleApp1  // toolbox
{

    // tool 1

    class student
    {
        public string name { get; set; }

        public void greet()
        {
            Console.WriteLine($"hello my name is  { name}");
        }
    }

    //tool 
    //a teacher tool

    class teacher
    {
        public string name { get; set; }

        public void teach()

        {
            Console.WriteLine($"{name} is teaching C# programming");
        }

        public class person // class
        {
            private string name;
            private int age;
            public person(string name, int age) // constructor
            {
                this.name = name;
                this.age = age;

            }

            public void displayinfo()
            {
                Console.WriteLine($"name: {name}, age: {age}");
            }
        }
        internal class Program // specific type of tool - hammer
        {
            static void Main(string[] args) // function of a hammer
            {
                // use theese tools
                student student = new student();
                student.name = "alice";

                teacher teacher = new teacher();
                teacher.name = "Mr. Smith";

                student.greet();
                teacher.teach();

                Console.WriteLine("Hello, World!");

                person person1 = new person("john", 40); // object instance
                person person2 = new person("alice", 45); // object instance

                person1.displayinfo();
                person2.displayinfo();


                try
                {
                    int x = 10;
                    int y = 0;
                    int result = x / y;

                    Console.WriteLine( result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("error " + ex.Message);
                }

            }
        }
    }
}