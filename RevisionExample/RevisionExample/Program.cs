namespace RevisionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // conditional statements

            // prompt user to write a number
            Console.WriteLine("Please enter any number");
            //use console.reeadline to capture number> convert to int
            
             int num = int.Parse(Console.ReadLine());
            if (num > 0) {
                Console.WriteLine("positive number ");
            }else if(num < 0) {
                Console.WriteLine("negative number");

            }
            else
            {
                Console.WriteLine("number is zero");
            }

            //mulltiple methods with different functionalities
            //then call one or more functionalities in other methods
            sayhello();
            int sum = 0;
                Console.WriteLine(calc(2,4));

            Person person1 = new Person("john", 25);
            Person person2 = new Person("Alice", 30);
            person1.Displayinfo();
            person2.Displayinfo();
        }

        static void sayhello()
        {

            Console.WriteLine("hello from a method outside");
        }

        static int calc(int A, int B)
        {
            int a = int .Parse(Console.ReadLine());
            int b = int .Parse(Console.ReadLine());
            return a + b;
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Displayinfo()
        {
            Console.WriteLine($"name {name}, Age: {age}");
        }
    }
}
