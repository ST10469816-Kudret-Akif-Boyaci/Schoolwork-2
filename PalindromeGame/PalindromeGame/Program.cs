namespace PalindromeGame
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");


            //introduce the user to the game
            //prompt the user to guess whether the given name is a palidrome or not

            Console.WriteLine(" welcome to the palindrojme game");
            Console.WriteLine("guess whether the given word is a palindrome (reads the same backwards)");



            //an array of strings of words

            string[] words = { "racecar", "hello", "madam", "world", "level" };
            Random random = new Random();
            int score = 0;

            for (int i = 0; i < 3; i++) {  //pick a random word 3 times / 3 lives
                string word = words[random.Next(words.Length)];  //pick a random word

                Console.WriteLine($" \n word: {word}");
                Console.Write("is this a palindrome? (yes/no) \n");
                string guess = Console.ReadLine().ToLower();

                bool ispal = ispalindrome(word);
                if ((guess == "yes" && ispal) || (guess == "no" && !ispal))
                {
                    Console.WriteLine("correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            Console.WriteLine($"Game Over, your score is: {score}/3");
        }

        //helper pethod to check if a word is palentrome or not

        static bool ispalindrome(string word)
        {
            char[] chars = word.ToCharArray(); // MADAM = MADAM
            Array.Reverse(chars);
            string reversedword = new string(chars);
            return word == reversedword;
        }
    }
}
