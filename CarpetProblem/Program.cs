namespace CarpetProblem
{

    //create a carpet class
    //within a class - using Acccessors and mutators

    public class carpet
    {
        private string type;
        private double priceperSQM;
        private double sizeperSQM;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        //accessor and mutator for price

        public double PriceSQM
        {
            get { return priceperSQM; }

            set
            {
                if (value >= 0)
                    priceperSQM = value;
                else Console.WriteLine("invalid price, cant be neagtive");
            }
        }
            
            public double SizeperSQM
        {
            get { return sizeperSQM; }
            set
            {
                if (value >= 0)
                    sizeperSQM = value;
                else Console.WriteLine("invalid size, cant be neagtive");
            }
        }

        //calculate the total price of the carpet using the size and price per SQM
        public double calculatetotalprice()
        {
            return priceperSQM * sizeperSQM;
        }

        //display thrdr prices and the sizes to the customers
        public void displaycarpetdetails()
        {
            Console.WriteLine($"typr: {Type}");
            Console.WriteLine($"price per SQM: {PriceSQM} rand");
            Console.WriteLine($"size in SQM: {sizeperSQM} meeter squared");
            Console.WriteLine($"total price: {calculatetotalprice} rands");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //two different carpets
            carpet carpet1 = new carpet();
            carpet1.Type = "wool";
            carpet1.PriceSQM = 25.99;
            carpet1.SizeperSQM = 10;

            carpet carpet2 = new carpet();
            carpet1.Type = "nylon";
            carpet1.PriceSQM = 15.99;
            carpet1.SizeperSQM = 15;

            //display details for carper
            Console.WriteLine("Carpet 1 details: ");
            carpet1.displaycarpetdetails();
            Console.WriteLine();

            Console.WriteLine("Carpet 2 details: ");
            carpet2.displaycarpetdetails();
            Console.WriteLine();
        }
    }
}
