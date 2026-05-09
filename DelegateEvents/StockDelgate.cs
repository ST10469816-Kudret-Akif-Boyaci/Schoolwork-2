using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
    //event Class with changes in a stock changes (event)
    public class stock
    {
        //define delegate for stock price change event
        public delegate void PricechangeEventHandler(decimal oldprice, decimal newprice);

        //declare event of type pricechangeeventhandler

        public event PricechangeEventHandler Pricechanged; //from old to new price

        private decimal price;

            //property for stock price - getter and setters

        public decimal Price
        {
            get { return price; }
            set { if (value != price)
                {
                    decimal oldprice = price; 
                    price = value;
                    onpricechanged(oldprice, price);  // a method to raise pricechanged event
                }
                }
        }
        // a method to raise pricechanged event
        protected virtual void onpricechanged(decimal oldprice, decimal newprice)
        {
            Pricechanged?.Invoke(oldprice, newprice);
        }
    }
    public class StockDelgate
    {
        static void Main(string[] args)
        {
            //create an object of the stock class 
            stock stock1 = new stock();

            //subscribe to the price changed event
            stock1.Pricechanged += (oldprice, newprice) => Console.WriteLine($"stock price changed from {oldprice} to {newprice}");

            //change stock price
            stock1.Price = 50.75m;
        }
    }
}
