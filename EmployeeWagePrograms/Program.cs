using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckAttendence checkattendence = new CheckAttendence();
            checkattendence.Attendence();
            Console.ReadLine();

        }
    }
}
