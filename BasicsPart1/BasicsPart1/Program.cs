namespace BasicsPart1
{

    //structures - data structures used to define points
    //enumerators - used to define the iterations eg days of the week
    //porperties - getters and setters
    // combine al of these C# types with classes and methods to create apps - part1 of POE

    //structure representing a 2d point - template of a class



    //1.1
   public struct point  //a template of a class but to define points
    {
        public int X;
        public int Y;

        public point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }



    //1.2
    public class Shape
    {
        //automatic properties - getters and setters

        public string Name { get; set; }
        public point position { get; set; }

        public Shape(string name, int x, int y)
        {
            Name = name;
            position = new point(x, y);
        }

        public void displayinfo()
        {
            Console.WriteLine($"Name: {Name}, Position: ({position.X}, {position.Y})");
        }




    }//1.3

    //enumerators
    public enum daysofweek
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,

    }

    //class reepresenting a schedule
    public class schedule
    {
        private daysofweek currentday;

        public schedule(daysofweek initialday)
        {
            currentday = initialday;
        }

        public void nextday()
        {
            currentday = (daysofweek)(((int)currentday + 1) % 7);
        }

        public void displaycurrentday()
        {
            Console.WriteLine($"Today is {currentday}");
        }
    }
 


    //1.4
    //use the system.io - allows to import files and read from them





    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //instantiate an object of a struct - similarly to a class
            point point1 = new point(10,29);
            Console.WriteLine($"point coordinates: ({point1.X}, {point1.Y})");


            //initiate an object of a class
            Shape rectangle = new Shape("Rectangle", 10,20);
            rectangle.displayinfo();



            //invoke an enum object
            daysofweek today = daysofweek.tuesday;
            Console.WriteLine("today is: " + today);



            //create instance objects
            schedule schedule = new schedule(daysofweek.tuesday);
            for (int i = 0; i < 7; i++)
            {
                schedule.displaycurrentday();
                schedule.nextday();   // Chat overlaps to the next day
            }


            //spesify the path to your file - text file
            string filepath = "C:\\Users\\lab_services_student\\source\\repos\\BasicsPart1\\BasicsPart1\\bin\\Debug\\example.txt";
            //check if file exists
            if (File.Exists(filepath))
            {
                //open file for reading
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    // read and display lines from the file untill the end
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("file doesnt exist");
            }
        }
    }
}
