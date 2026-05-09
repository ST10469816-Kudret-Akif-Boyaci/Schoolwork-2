namespace IceTaskBanking
{

    //declare the base class - accounts with generic info about any account

    public class Account  // base class
    {
        // variables  foor any account
        protected string Accountnumber; //access it in both the base and the derived class
        protected double Balance;

        //initialize these variables with a constructor
        public Account (string accountnumber, double initialbalance)
        {
            Accountnumber = accountnumber;
            Balance = initialbalance;
        }

        //Deposit into the account
        public virtual void Deposit(double amount) // to declare as a virtual to override later
        {
            if (amount <= Balance)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("insufficent funds");
            }
        }

        //withdraw from account
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
            Console.WriteLine($"withdrawn: {amount}. New balance: {Balance}");
        }

        //check the balance
        public virtual void Displaybalance()
        {
            Console.WriteLine($"Account number: {Accountnumber} \n  balance: {Balance}");
        }


    }

    //derived classes -> two classes for savings Account and the checque account

    public class Savings: Account  //derived class
    {
        private double InterestRate;

        public Savings(String accountnumber, double initialbalance, double interestRate) : base(accountnumber, initialbalance)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            Console.WriteLine($"Interest accurred: {Balance * InterestRate/100}");
        }
    }

    public class Cheque : Account  //derived class
    {
        private double Overdraftlimit;

        public Cheque(string accountnumber, double initialbalance, double overdraftlimit) : base(accountnumber, initialbalance)
        {
            Overdraftlimit = overdraftlimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + Overdraftlimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("exceeds overdraft limit");
            }
        }
    }

    //bussiness account class - demonstrate encapsulation + inheritance
    public class Bussinessaccount : Account
    {
        private string Bussinessname;

        public Bussinessaccount (string accountnumber, double initialbalance, string bussinessname) : base(accountnumber, initialbalance)
        {
            Bussinessname = bussinessname;
        }

        public string Getbusinessname()
        {
            return Bussinessname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //create objects only of the derived classes
            //for the saving, the checque, bussiness

            Savings savings = new Savings("sa213334", 10000, 2.5);
            savings.Deposit(500);
            savings.Withdraw(490);
            savings.Displaybalance();

            Cheque cheque = new Cheque("sa287564", 20000, 1000);
            cheque.Deposit(500);
            cheque.Withdraw(400);
            cheque.Displaybalance();

            Bussinessaccount bussinessaccount = new Bussinessaccount("BA55555", 50000, "tech solutions");
            bussinessaccount.Displaybalance();
            Console.WriteLine("Account type:business account");
        }
    }
}
