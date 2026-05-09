using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateExamples.Core;

namespace DelegateExamples.Core
{
    public delegate void notificationhandler(string message);
    public class Notifier
    {
       
        private notificationhandler handler;

        //constructor injection - oop principle

        public Notifier(notificationhandler handler)
        {
            this.handler = handler; 

        }

        public void  notify(string message)
        {
            if (handler != null)
            {
                handler(message); // invoke delegate
            }
        }


        
    }
}
