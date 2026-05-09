using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateExamples.Core;
using DelegateExamples.Services;

namespace DelegateExamples
{
    // delegates map functionalities to an object such that we can call the object multiple times instead of calling the actual method
    //singlecast delegate - one method mapped into an object
    //multicast delegate - multiple methods mapped into a single object
    //different buttons (methods) on ui mapped into a singledelegate

    public delegate int mathoperation(int x, int y);

    //create a class calsulator where we are going to temporarily store data in a cache with a dictionary
    public class calculator
    {
        private Dictionary<string, int> cache = new Dictionary<string, int>();

        public int Performanceoperation(int x, int y, mathoperation operation)
        {
            string key = $"{x} - {y} - {operation.Method.Name}";
            if (cache.ContainsKey(key))
            {
                Console.WriteLine($"result retrieved from cache for {operation.Method.Name}({x},{y})");
                return cache[key];
            }
            else
            {
                int result = operation(x, y);
                cache[key] = result;
                return result;
            }

        }
    }

    internal class Program
    {
        //define a delegate to map a method
        delegate void operationdelegate(int x, int y);
        static void Main(string[] args)
        {
            operationdelegate operationdelegate1 = add; //creation of an object but for a method
            operationdelegate1 += multiply;
            operationdelegate1 += divide;
            operationdelegate1 += substract;

            operationdelegate1(5, 3);


            calculator calculator1 = new calculator();
            mathoperation multiply2 = (x, y) => x * y;
            mathoperation add2 = (x, y) => x + y;
            mathoperation substract2 = (x, y) => x - y;

            

            int result1 = calculator.performanceoperation(5, 3, multiply2);
            int result2 = calculator.performanceoperation(5, 3, add2);
            int result3 = calculator.performanceoperation(5, 3, substract2);

            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result1: " + result1);


            Console.Title = "Delegate example - notification system";

            NotificationService notificationService1 = new NotificationService();

            //assign methods to delegate
            notificationhandler emailhandler = NotificationService.sendmail;
            notificationhandler smshandler = NotificationService.sendsms;
            notificationhandler consolehandler = NotificationService.sendconsole;
            notificationhandler whatsapphandler = NotificationService.sendwhatsapp;

            //multicast delegate (combine methods)
            notificationhandler multihandler = emailhandler + smshandler + consolehandler;

            //create notifier with injected delegate
            Notifier notifier = new Notifier(multihandler);
            notifier.notify("system update completed successfully");
            Console.WriteLine("\n ----adding whatsapp dynamically----\n");

            // add another method att runtime
            multihandler += notificationService1.sendwhatsapp;

            notifier = new Notifier(multihandler);
            notifier.notify("new feature deployed");

            Console.ReadKey();
        }

        //method we are trying to map
        static void add(int x, int y)
        {
            Console.WriteLine($"add result: {x + y}");
        }

        //multicast delegate - multiple methods to a single object of a delegate
        static void multiply(int x, int y)
        {
            Console.WriteLine($"multiply results: {x * y}");
        }

        static void divide(int x, int y)
        {
            Console.WriteLine($"divide results: {x / y}");
        }

        static void substract(int x, int y)
        {
            Console.WriteLine($"substract results: {x - y}");
        }

    }
}
