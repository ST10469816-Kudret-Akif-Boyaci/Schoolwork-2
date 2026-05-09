using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    public class student
    {

        public string name { get; set; }

            public int studentnum { get; set; }

        public double mark { get; set; }

        public student(string name1, int studentnum1, double mark1)
        {
            name = name1;
            studentnum = studentnum1;
            mark = mark1;


        }
        public string getdetails()
        {
            return $"{name} ({studentnum} ) - mark: {mark} ";
        }
       
    }
}
