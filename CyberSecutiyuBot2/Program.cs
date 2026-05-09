using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CyberSecurityBot2.Models;
using CyberSecurityBot2.Services;
using CyberSecurityBot2.UI;
using System.Windows.Markup;

//checklist
//ULPOAD AN asci LOGO FROM THE LOGO.TXT -done
//chatbot conversation - generate response - done
//string maupilation - tolwercase, touppercase, contains -done 
//input validation - in combination with string manupilation - done
//command response - done
//conversation history - done
// structured C# classes - done in other work
//interface (IResponse) - not done
//better chatbot architechture - not done
//typing effect - not done
//voice greeting - not done




//integrate the oop principles into the chatbot
//interface, inheritance, polymorphism, etc.
//Iresponder
//inheritance withwith greetingsresponder, helpresponder, passwordresponder.
//audioServices - import
//update the chatbot with audio services

namespace CyberSecurityBot2
{
    //why do we need seperate classes in seperate files
    //for cleaner development also easier to debug
    //create seperate classesnin seperate files
    //create/instantiate objects of these classes in program.cs
    internal class Program
    {
        static void Main(string[] args)  //entry point of program
        {
            Console.WriteLine("Hello, World!");

            //define the title of the program
            Console.Title = "cybersecurity Awarenes bot";

            //Object of the services class
            AssetService assets = new AssetService();
            AudioService audio = new AudioService();

            assets.showwelcomescreen();

            audio.Playgreeting();

            // prompt the user to enter their name
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine() ?? "";

            //need to check if the input string is a null or emplty space
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Nmae cannot be empty. pleas enter your name: ");
                name = Console.ReadLine() ?? "";
            }

            //trimming the spaces after entering your name - string manupilation
            //create/instantiate objects of the userprofile class
            // var is a data type that accomodates different data types into a single data type
            var user = new UserProfile()
            {
                name = name.Trim() //string manupilation
            };

            displayuserinfo(user);

            ChatBot bot = new ChatBot();
            bot.Run(user.name);

            Console.WriteLine("application closed."); // Pressing exit as an input string

            //checklist
            //ULPOAD AN asci LOGO FROM THE LOGO.TXT -done
            //chatbot conversation - generate response - done
            //string maupilation - tolwercase, touppercase, contains -done 
            //input validation - in combination with string manupilation - done
            //command response - done
            //conversation history - done
            // structured C# classes - done in other work
            //interface (IResponse) - not done
            //better chatbot architechture - not done
            //typing effect - not done
            //voice greeting - not done

            //display the applications - string manupilation
            //the name of the user, the chats and the logintime
            //use some of the string manupilation from the table discussed in class
            Console.WriteLine($"welcome {user.name}");
            Console.WriteLine($"login time: {user.logintime}");

            // staff introduced - ??, Trim() IsNullOrWhiteSpace
            //more on string maupilation exercises


            //Console.WriteLine($"uppercase name: {user.name.ToUpper()}");
            //Console.WriteLine($"lowercase name: {user.name.ToLower()}");
            //Console.WriteLine($"name lenght: {user.name.Length}");

            //include the user interface part from the class UI

            //var ui = new ConsoleUI();
            //ui.header();
            //ui.BotMessage("Welcome to the cybersecurity awarebes bot");

            //method used for display purpopes
            static void displayuserinfo(UserProfile user)
            {
                Console.WriteLine();
                Console.WriteLine("user information");
                Console.WriteLine("-------------------");
                Console.WriteLine($" welcome {user.name}");
                Console.WriteLine($" logintime: {user.logintime}");

                //staff intoduced - ??, Trim(), IsNullOrWhiteSpace
                Console.WriteLine($"uppercase name: {user.name.ToUpper()}");
                Console.WriteLine($"lowercase name: {user.name.ToLower()}");
                Console.WriteLine($"name lenght: {user.name.Length}");
            }


        }
    }
}
