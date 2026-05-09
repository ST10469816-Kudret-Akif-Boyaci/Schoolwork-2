using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMonitorICE3
{
    public delegate void alerteventhandler(string message);

   
    public class Patient
    {
        public string PatientID;
        public string FullName;
        public int Age;
        public int HeartRate;
        public double Temperature;
        public int OxygenLevel;
        public void values()
        {
            PatientID = "123";
            FullName = "bob bobby";
            Age = 19;
            HeartRate = 20;
            Temperature = 40.0;
            OxygenLevel = 31;
        }
    }

    public class HospitalStaff
    {
        string StaffID;
        string FullName;
    }
    public class doctor: HospitalStaff
    {
        public string respond2()
        {

            return "Doctor preparing emergency treatment";
        }
    }
    public class nurse : HospitalStaff
    {
        public string respond1()
        {
            
            return "Nurse responding to Room 5";
        }
    }

    public class vitalcheck
    {
        public event alerteventhandler alert;

        public void checker()
        {
            Patient p1 = new Patient();
            if(p1.HeartRate > 100 || p1.HeartRate < 60)
            {
                Console.WriteLine("alert heartrate");
                onalert();

                alerteventhandler al = sendmail;
                al += sendsms;
                al += sendconsole;
            } if (p1.Temperature > 38.0)
            {
                Console.WriteLine("alert temperature");
                onalert();
            } if (p1.OxygenLevel < 95)
            {
                Console.WriteLine("alert oxygen");
                onalert();
            }

        }
        protected virtual void onalert()
        {
            alert?.Invoke("alert");

        }
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
    }


    public class Program
    {
        static void Main(string[] args)
        {
            vitalcheck v1 = new vitalcheck();
            v1.alert += (al) => Console.WriteLine("handling button click event");
            v1.checker();

            v1.alert += (messsage) => Console.WriteLine("handling button click event");

            Patient patient = new Patient();
            patient.PatientID = "12345";
            

            
        }

        
    }
}
