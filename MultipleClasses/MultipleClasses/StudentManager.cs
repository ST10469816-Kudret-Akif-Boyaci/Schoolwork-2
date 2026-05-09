using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    public class StudentManager
    {

        private List<student> students = new List<student>();   

        public void addstudent(student student)
        {
            students.Add(student);
        }

        public double GetAvarageMark()
        {
            return students.Average(s => s.mark);

        }

        public List<student> getallstudents()
        {
            return students;
        }
    }
}
