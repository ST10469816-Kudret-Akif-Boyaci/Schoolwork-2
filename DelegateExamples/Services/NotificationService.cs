using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples.Services
{
    public class NotificationService
    {
        //create different methods for notification services
        //different notification platforms - sms, email, console terminal
        //all these platforms / methods should be mapped to a single delegate

        public static void sendmail(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[through email protocol]: message");
            Console.ResetColor();
        }

        public static void sendsms(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[through sms protocol]: message");
            Console.ResetColor();
        }

        public static void sendconsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[console]: message");
            Console.ResetColor();
        }

        public static void sendwhatsapp(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[through whatsapp protocol]: message");
            Console.ResetColor();
        }
    }
}
