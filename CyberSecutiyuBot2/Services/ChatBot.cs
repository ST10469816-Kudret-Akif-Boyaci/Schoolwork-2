using CyberSecurityBot2.UI;
using CyberSecutiyuBot2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyberSecurityBot2.Services
{
    internal class ChatBot
    {
        //how and where do we save the conversation
        //datastructure allows us to save the conversation - list
        public List<string> conversationhistory = new List<string>();
        private List<IResponder> Responders = new List<IResponder>();
       

        private string Getresponse(string message)
        {
            foreach (IResponder responder in Responders)
            {
                if (responder.Canrespond(message))
                {
                    return responder.Getresponse();
                }
            }
            return "I didnt understand that.";
        }
        public ChatBot()
        {
            
            Responders.Add(new GreetingResponder());
            Responders.Add(new HelpResponder());

            //you can also do the same for  password, phishing, safebrowsing
        }

        public void Run(string username)
        {
            Console.WriteLine($"hello {username}! Ask me about cybersecurity.");
            Console.WriteLine($"type 'help' to see what I can do");
            Console.WriteLine($"type 'exit' to close the chatbot");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You: ");
                Console.ResetColor();

                // ?? are used to check for nullable characters / strings
                string input = Console.ReadLine() ?? "";

                string message = normalizeinput(input);

                //conditional statement to check for messages between You and the bot
                if (message == "")
                {
                    Console.WriteLine("Bot: please type something");
                    continue;
                }
                if (message == "exit")
                {
                    Console.WriteLine("BOT: goodbye! Stay safe online.");
                    break;
                }
                conversationhistory.Add(message);

                //define responses for the BOT to be able to communicate with the user

                string response = generateresponse(message);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"BOT: {response}");
                Console.ResetColor();


            }
        }

        //normalize the user input
        private string normalizeinput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";

            return input.Trim().ToLower();
        }

        //generate chatbot response
        //sorponse for passwords, phising, browsing, history
        private string generateresponse(string message)
        {
            //set of conditional statements
            if (message.Contains("how are you"))
                return "I am functioning normally and ready to assist you";

            if (message.Contains("purpose"))
                return "my purpose is to assist you";

            if (message.Contains("help"))
                return showhelp();

            if (message.Contains("password"))
                return passwordadvice();

            if (message.Contains("phising"))
                return phisingadvice();

            if (message.Contains("browsing"))
                return browsingadvice();

            if (message.Contains("history"))
                return showhistory();

            return "I didnt understant your query, please try asking about   passwords, phising, browsing, history";
        }

        //method response for help  passwords, phising, browsing, history
        private string showhelp()
        {
            return " you can ask me about  passwords, phising, browsing or type history";
        }

        private string passwordadvice()
        {
            return "use string passwords with letters, numbers and symbols. Avoid using the same password";
        }

        private string phisingadvice()
        {
            return " be carefull of suspicious emails asking for personal information or urgent action";
        }

        private string browsingadvice()
        {
            return "always check that the websites use HTTPS and avoid downloading from unknown sites.";
        }

        private string showhistory()
        {
            if (conversationhistory.Count == 0)
                return "NO conversation history yet";

            string history = "conversationhistory \n";

            foreach (var item in conversationhistory)
            {
                history += "-" + item + "\n";
            }
            return history;
        }

    }

}
