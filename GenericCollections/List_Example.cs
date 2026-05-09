using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class List_Example
    {

    //a set of data structures to hold / store information in set of predefined variables
    //a number of generic collections
    //lists, linkedlinks, dictionary,ques, stacks, sorted lists
    public void listmethod()
    {
        //basic data collection - list
        List<string> product = new List<string>(); // storing products in a list

        // add different products to the list
        //several methods from a class called list - add method
        product.Add("computer");
        product.Add("phone");
        product.Add("ipad");

        // you need to display these products in a cart - online shopping
        Console.WriteLine("product");
        foreach (var item in product) //accessing the roducts in a cart
        {
            Console.WriteLine(item);
        }

        //after wieving you are unhappy with one of the products
        //remove from the list of products
        product.Remove("phone"); // the remove method comes from class list

        //display the remaining product
        Console.WriteLine("\n products after removal");
        foreach (var item in product) //accessing the roducts in a cart
        {
            Console.WriteLine(item);
        }

    }
}
}
