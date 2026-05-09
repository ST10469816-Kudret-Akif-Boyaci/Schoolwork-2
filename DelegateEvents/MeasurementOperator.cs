using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
    //measurement operator device that will measure themperature in a venue
    //create a temperature monitor class
    //within the class - event handlers to assist in raising the event that so that we can do the measurements

    public class temperaturemonitor
    {
        //create an event handler
        public event EventHandler<EventArgs> TemperatureChanged;

        public void monitor()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int temperature = random.Next(-20, 50);
                Console.WriteLine(temperature);

                System.Threading.Thread.Sleep(1000);  //wait for 1 second
            }
        }
            protected virtual void ontemperaturechanget(EventArgs e)
        {
            TemperatureChanged?.Invoke(this,e);
        }
        
    }
    public class temperatureeventargs : EventArgs
    {
        public int temperature { get; } //get temperature results with a getter

        //use a constructor to initializethese temperature values
        public temperatureeventargs(int temperature1)
        {
            temperature = temperature1;
        }
    }
    public class MeasurementOperator
    {

        static void Main (string[] args)
        {
            MeasurementOperator m = new MeasurementOperator();
            temperaturemonitor monitor1 = new temperaturemonitor();
            monitor1.TemperatureChanged += temperaturechangeeventhandler;
            monitor1.monitor();
        }

        static void temperaturechangeeventhandler (object sender, temperatureeventargs e)
        {
            Console.WriteLine($"temperature changed: {e.temperature} degrees C");
        }
    }
}
