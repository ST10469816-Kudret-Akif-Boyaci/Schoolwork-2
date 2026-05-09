using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
    //define a delegate for button click event
    public delegate void buttonclickeventhandler();

    //define a class for several buttons
    public class button
    {
        //declare several buttons (methods) that can be linked to a delegate
        public event buttonclickeventhandler click;

        public void simulateclick()
        {
            Console.WriteLine("button clicked");
            onclick();  //raise the click event
        }
            //method to raise the click event
            protected virtual void onclick()
        {
            click?.Invoke();
        
        }
    }

    internal class Program
    {
        //link the delegates with events (methods)
        //events are methods with actions to perform a certain operation
        //button that should then take an action from the user and returns results
        //button linked to methods such that we can create an object (delegate) to link all methods
        static void Main(string[] args)
        {
            button button1 = new button(); //object of the button class

            //subscribe to the click event
            button1.click += () => Console.WriteLine("handling button click event");

            //simulate button click
            button1.simulateclick();
        }
    }
}
