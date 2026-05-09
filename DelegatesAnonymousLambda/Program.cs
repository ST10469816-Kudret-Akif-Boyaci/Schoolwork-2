using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAnonymousLambda
{
    //student parks processor application
    //create a program that stores the student marks in list (generic collections) and process them using
    //delgate
    //Anonymous method
    //lambda expression
    //program must
    //1 display all marks
    //2 calculate and display passing marks
    //3 display failing marks
    // find and display bonus adjusted marks
    internal class Program
    {
        //delegate that takes an integer and return =s a boolean
        //we will use it for checking conditions such as pass/fail
        public delegate bool markcondition(int mark);

        //delegate that takes an integer and returns an integer
        //we will use it for transforming marks for example adding bonus marks
        public delegate int markoperation(int mark);


        static void Main(string[] args)
        {
            //a list of student marks
            List<int> marks = new List<int>() { 45, 67, 39, 82, 90, 55, 28, 74 };

            Console.WriteLine("student marks processor");

            //display original marks
            Console.WriteLine("original marks: ");
             displaymarks(marks);

            //---------------------------------------------------------------------------------
            //using anonymous method with a delegate
            //tyhis anonymous method check whether a mark is a pass
            //a pass mark is 50 or above
            markcondition ispass = delegate (int mark)  //this is a anonymous method with the delegate
            {
                return mark >= 50;
            };

            Console.WriteLine("\n passing marks (anonymous method): ");
            filtermarks(marks, ispass);

            //---------------------------------------------------------------------------------
            //using a lambda expression with a delegate
            //this lanbda expression ghecks whether a mark is a fail or not
            //a failing mark is below 50

            markcondition isfail = mark => mark < 50;  //lambda expression symbol =>

            Console.WriteLine("\n failing marks (lambda method): ");
            filtermarks(marks, isfail);

            //---------------------------------------------------------------------------------
            //using another lambda expression for transformation
            //this lambda expression to add 5 bonus marls to each students marks
            //it also ensures that the final mark does not exceed 100
            markoperation addbonus = mark => (mark + 5 > 100) ? 100 : mark + 5;

            Console.WriteLine("\n marks after addding bonus (+5): ");
            transformmarks(marks, addbonus);

            displayaverage(marks);

            Console.WriteLine("\n Press any key exit");
            Console.ReadKey();

            

        }
        //a mehod to calculate and display the average marks
        static void displayaverage(List<int> marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            double average = (double)sum / marks.Count;
            Console.WriteLine($"average mark: {average:F2}");
        }

        //method to diplay all marks
        static void displaymarks(List<int> marks)
        {
            foreach (int mark in marks)
            {
                Console.WriteLine(mark + " ");

            }
            Console.WriteLine();
        }
        //method that filters marks based on delegate condition
        //thw condition is passed in so we can reuse this method
        //for pass / faill / distinction, etc

        static void filtermarks(List<int> marks, markcondition condition)
        {
            foreach (int mark in marks)
            {
                if (condition(mark))
                {
                    Console.WriteLine(mark + " ");
                }
              

            }
            Console.WriteLine();
        }
        //method that transforms each mark using a delegat operation
        //this can be used for adding bonus marks, scaling or even deduction
        static void transformmarks(List<int> marks, markoperation operation)
        {
            foreach (int mark in marks)
            {
                //apply the delagate operation to the marks
                int newmark = operation(mark);
                Console.WriteLine(newmark + " ");
            }
            Console.WriteLine();
        }

    }
}
