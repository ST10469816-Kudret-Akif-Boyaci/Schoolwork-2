using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        public string name { get; set; }

        public int age { get; set; }

        public string department { get; set; }

        public string position { get; set; }

        public override string ToString()
        {
            return $"{name} | Age: {age} | Department: {department} | Position: {position}";
        }

    }
}
