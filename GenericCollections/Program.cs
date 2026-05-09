using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class Program
    {

        //a set of data structures to hold / store information in set of predefined variables
        //a number of generic collections
        //lists, linkedlinks, dictionary,ques, stacks, sorted lists
        static void Main(string[] args)
        {
            List_Example listexample = new List_Example();
            listexample.listmethod();

            DictionaryExample dictexample = new DictionaryExample();
            dictexample.dictionarymethod();

            SortData sortData = new SortData();
            sortData.sortmethod();

            QueueExample queueexample = new QueueExample();
            queueexample.Queuemethod();

            SackExample sackexample = new SackExample();
            sackexample.stackmethod();

            LinkedListExample listlistexample = new LinkedListExample();
            listlistexample.linkedlistmethod();


        }
    }
}
