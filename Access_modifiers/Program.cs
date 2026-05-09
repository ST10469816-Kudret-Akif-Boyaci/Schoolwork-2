namespace Access_modifiers
{

    /// <summary>
    /// Access modifiers
    /// 1. public
    /// 2.private
    /// 3.protected
    /// 4.internal
    /// </summary>
    /// 
    //public class myclass
    //{

    //    public int publicfield = 10;
    //    public void publicmethod()
    //    {
    //        Console.WriteLine("this is a public method");
    //    }
    //}





    //protected access modifiers
    //base (parent) class -> derived (child) class:  protected accessibility

    //public class mybaseclass
    //{
    //    protected int protectedfield = 20;


    //    protected void protectedmethod()
    //    {
    //        Console.WriteLine("this is a protected method");
    //    }
    //}

    //public class myderivedclass : mybaseclass // colon is used for inheritance
    //{ // create a publicly accessible method that has access to the protected items

    //    public void accessprotectedmethod()
    //    {
    //        Console.WriteLine($"protected field value: {protectedfield}");
    //        protectedmethod();
    //    }
    //}





    //private access modifier
    //public class myclass3
    //{
    //    private int privatefield = 40;

    //    private void privatemethod()
    //    {
    //        Console.WriteLine("this is a private method");
    //    }

    //    //to beable to access these private variables
    //    // we need a public accessible method that we can use to access private items
    //    public void accesssprivatemembers()
    //    {
    //        Console.WriteLine($"private field value: {privatefield}");
    //        privatemethod();
    //    }
    //}







    // internal access modifier
    internal class myclass4
    {
        internal int internalfield = 20;

        internal void internalmethod()
        {
            Console.WriteLine("this is an internal method");
        }
    }




    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //create/ instantiate objects of this class
            //myclass obj = new myclass();
            //Console.WriteLine($"public field value: {obj.publicfield}");
            //obj.publicmethod();



            //myderivedclass obj2 = new myderivedclass();
            //obj2.accessprotectedmethod();



            //myclass3 obj3 = new myclass3();
            //obj3.accesssprivatemembers();


            myclass4 obj4 = new myclass4();
            Console.WriteLine($"internal field value: {obj4.internalfield}");
            obj4.internalmethod();
        }
    }
}
