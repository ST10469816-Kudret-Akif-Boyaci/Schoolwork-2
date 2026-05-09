namespace LetterGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //string.join(): combines an array  of characters into a string 
            //string.contains(): checks if a string contains a spesific character

            string secretword = "classroom"; //the word to guess some of the characters
            char[] guessedletters = new char[secretword.Length]; // array to track guessed letters
            for (int i = 0; i < guessedletters.Length; i++)
            {
                guessedletters[i] = '_'; //initialize with underscore

            }
            int attempts = 6; // number of allowed incorrect guesses
            bool wordguessed = false;

            while (attempts > 0 && !wordguessed) {

            Console.WriteLine($"attempts left: {attempts}");
            Console.WriteLine("current word " + string.Join("", guessedletters));
            Console.WriteLine("enter a letter character:");
            char letter = Console.ReadLine()[0];  // read the first character of input

            bool correctguess = false;
            for (int i = 0; i < secretword.Length; i++)
            {
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
                if (string.Join("", guessedletters) == secretword)
                {
                    wordguessed = true;
                    Console.WriteLine("congratulations you guessed the word: "+ secretword);
                }
            }
            if (!wordguessed)
            {
                Console.WriteLine("out of attempts! the word was: " + secretword);
            }
        }
    }
}
