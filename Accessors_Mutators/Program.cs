using System.Xml.Serialization;

namespace Accessors_Mutators
{

    public class person
    {
        //automatic properties

        protected string name {  get; set; }

       // protected int age { get; set; }

        protected int id { get; set; }


        //initialized variables with constructors

        public person(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        //display of the person info

        public virtual void displayinfo()
        {
            Console.WriteLine($"name: {name}, id: {id}");
        }
    }

    public class student// : person  //interit from the person class
    {
        //public int grade;
        //public student(string name, int id, int grade1) : base(name, id) // constructor to initialize
        //{
        //    grade = grade1;
        //}


        //accessors and mutators - methods that  WILL BE USED TO SET AND GET VALUES
        private string name;
        private int id;

        //accessor method of name
        public string getname()
        {
            return name;
        }

        //mutator method for name
        public void setname(string newname) //setter from automatic properties 
        {
            name = newname;
        }

        //accessor method for id
        public int getid()
        {
            return id;
        }

        //mutator method for id
        public void setid(int newid)
        {
            id = newid;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //student student1 = new student("aya", 123456, 45);
            //student.displayinfo();
        }
    }
}
