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
            //CheckAttendence checkattendence = new CheckAttendence();    \\UC1
            //checkattendence.Attendence();
            //Console.ReadLine();

            DailyEmpWage dailyempwage = new DailyEmpWage();
            DailyEmpWage.EmpWage();
            Console.ReadLine();

        }
    }
}
