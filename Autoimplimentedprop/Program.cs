using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoimplimentedprop
{
    public class Student
    {
        public int roll { get; set; }
        public string name { get; set; }
        public double percentage { get; set; }

        public string PrintStudent()
        {
            return $"RollNo={roll},Name={name},Percentage={percentage}";
        }
    }
}
