using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class QueueExample
    {

       public void Queuemethod()
       {

      
            //declare a queue object for storing variables in a queue collection
            Queue<string> printqueue = new Queue<string>();

            //adding documents to print queue
            //instead of using add method use - Enqueue
            printqueue.Enqueue("assignment");
            printqueue.Enqueue("test");
            printqueue.Enqueue("book");

            // display the print queue
            Console.WriteLine("print queue");
            foreach (var item in printqueue)
            {
                Console.WriteLine(item);
            }

            //print a document  - removing a document from a queue of documents
            Console.WriteLine("\n printing document: " + printqueue.Dequeue());

            // display the print queue
            Console.WriteLine("print queue after printing");
            foreach (var item in printqueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
