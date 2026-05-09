namespace NewEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //register a new employee to company database
            //new employee will come with name, department, year of starting the employment

            Console.WriteLine("====employee registiration system====");

            //prompt user to write their name
            Console.WriteLine("enter full name: ");
            string fullname = Console.ReadLine().Trim();

            //prompt the use to enter the department
            Console.WriteLine("enter department name: ");
            string department = Console.ReadLine().Trim();

            //year the employee joined
            Console.WriteLine("enter enter year of joining: ");
            string year = Console.ReadLine().Trim();


            //split fullname into parts
            string[] nameparts = fullname.Split(' ');

            if (nameparts.Length < 2) {

                Console.WriteLine("please enter both first and last name");
                return;
           }
            string firstname = nameparts[0].ToLower();
            string lastname = nameparts[1].ToLower();

            //generate corporate email
            string email = $"{firstname}.{lastname}@company.com";

            //generate employee id (dept + year + 2 letters of surname
           // string empid = $"{department.Substring(0,3).ToUpper()}{year}{lastname.Substring(0,2).ToUpper()}";
            string empid = $"{department.Substring(0, Math.Min(3,department.Length)).ToUpper()}{year}{lastname.Substring(0, Math.Min(3, lastname.Length)).ToUpper()}";

            // temporary password (reverse name + year
            char [] chars = firstname.ToCharArray();
            Array.Reverse(chars);
            string password = new string(chars) + "@" +year;

            //print these information on the console
            Console.WriteLine("\n ====generated details====");
            Console.WriteLine($"email: {email}");
            Console.WriteLine($"Employee ID: {empid}");
            Console.WriteLine($"Teporary Password: {password}");

            // check if department contais "IT"
            if (department.ToUpper().Contains("IT"))
            {
                Console.WriteLine("Access Level: Technical staff");

            }
            else
            {
                Console.WriteLine("Access Level: General staff");



                //string.join(): combines an array  of characters into a string 
                //string.contains(): checks if a string contains a spesific character

                string secretword = "classrom"; //the word to guess some of the characters
                char[] guessedletters = new char[secretword.Length]; // array to track guessed letters
                for (int i = 0; i < guessedletters.Length; i++)
                {
                    guessedletters[i] = ' '; //initialize with underscore

                }
                int attempts = 6; // number of allowed incorrect guesses
                bool wordguessed = false;

                Console.WriteLine($"attempts left: {attempts}");
                Console.WriteLine("current word " + string.Join("", guessedletters));
                Console.WriteLine("enter a letter character:");
                char letter = Console.ReadLine()[0];  // read the first character of input

                bool correctguess = false;
                for (int i = 0; i < secretword.Length; i++){
                    if (secretword[i] == letter)
                    {
                        guessedletters[i] = letter; // update the quessed letters array
                        correctguess = true;
                    }
                }
                if (!correctguess)
                {
                    attempts--;
                    Console.WriteLine("Incorrect guess");
                }
            }
        }
    }
}
