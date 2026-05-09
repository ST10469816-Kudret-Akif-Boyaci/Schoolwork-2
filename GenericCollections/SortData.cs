using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class SortData
    {
        public void sortmethod()
        {
            //dictionary a data structure with two parameters: key and value
            //dictionary usually used for cases where we nee to store 2 variables at a time
            //employee example: with name and age

            //a collection that takes the same format of a dictionary:key and value
            //sortedlist: also takes in the key and value pairs
            //but uses the values to sort in term oif ascending order
            SortedList<string, int> employeeage = new SortedList<string, int>();

            //adding employee ages
            employeeage.Add("alice", 30);  //add method comes from the dictionary class
            employeeage.Add("bob", 45);
            employeeage.Add("charlie", 40);

            //display the number of people employed in the company
            Console.WriteLine("employee age:");
            foreach (var employee in employeeage)
            {
                Console.WriteLine($"{employee.Key}: {employee.Value} years old");
            }

            // one of the employees quit - rmove one employee from dictionary
            employeeage.Remove("bob");

            //display the number of people employed in the company
            Console.WriteLine("employee age afrter removal");
            foreach (var employee in employeeage)
            {
                Console.WriteLine($"{employee.Key}: {employee.Value} years old");
            }

        }
    }
}
