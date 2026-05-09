using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot.UI
{
    public class ConsoleUI
    {

        public void header() {
        
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======CYBERSECURITY AWARENESS BOT======");
            Console.ResetColor();
            Divider();
        
        
        }

        public void Divider()
        {
            Console.WriteLine(new string('-', 60));


        }
        public void botmesssage(string message) {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("BOT: ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public void Typrbotmessaage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("BOT: ");
            Console.ResetColor();
            Console.WriteLine(message);

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }

            Console.WriteLine();
        }

    }
}
