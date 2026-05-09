using System;
using System.ComponentModel.DataAnnotations;

namespace FunWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // ask for two numbers using console.writeline
            // get these numbers using console.readline
            //change the text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("enter the first number");
            int num1 =int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            //perform the math operations: + - * /

            Console.BackgroundColor = ConsoleColor.Red;
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotiont = (double)num1 / (double)num2; // cast double for decimal numbers

            //Display result
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"difference: {difference}");
            Console.WriteLine($"product: {product}");
            Console.WriteLine($"quotiont: {quotiont}");

            // reset colors to default
            Console.ResetColor();
            Console.WriteLine("back to normanl");



            Console.Title = "color guess game";
            Random rnd = new Random();

            string[] colors = { "red", "blue", "green", "yellow" };
            ConsoleColor[] consoleColors =
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
            };

            int score = 0;


       //     Console.BackgroundColor = ConsoleColor.Red;

            //setting colors for user to choose from
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("this is the color guess game");
            Console.ResetColor();
            Console.WriteLine("Guess the word (not the color). \n");


            // for loop for each round to choose colors
            for (int round = 1; round <= 5; round++)
            {
                int wordindex = rnd.Next(colors.Length);
                int colorindex = rnd.Next(consoleColors.Length);

                Console.WriteLine($" round {round}");

                Console.ForegroundColor = consoleColors[colorindex];
                Console.WriteLine(colors[wordindex].ToUpper());

                Console.ResetColor();

                Console.WriteLine("enter your answer: ");
                string answer = Console.ReadLine().ToLower();
                //;

                if (answer == colors[wordindex])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! \n");
                    score++;


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong! \n");

                }
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"game over! Final Score: {score}/5");
            Console.ResetColor();

        }
    }
}
