using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoimplimentedprop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.roll = 25;
            student.name = "Abc";
            student.percentage = 71;

            Console.WriteLine(student.roll);

        }

    }
}
