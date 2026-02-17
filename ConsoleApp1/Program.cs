namespace ConsoleApp1  // toolbox
{

    // tool 1

    class student
    {
        public string name {  get; set; }

        public void greet()
        {
            Console.WriteLine ($"hello my name is " {name});
        }
    }

        //tool 
        //a teacher tool

    class teacher
    {
        public string name { get; set; }

        public void teach()

            { Console.WriteLine($"{name} is teaching C# programming");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
