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

            //DailyEmpWage dailyempwage = new DailyEmpWage();              \\UC2
            //DailyEmpWage.EmpWage();
            //Console.ReadLine();

            //PartTimeEmpWage partTimeempWage = new PartTimeEmpWage();      \\UC3
            //PartTimeEmpWage.PartTime();
            //Console.ReadLine();

            //SwitchCase switchCase = new SwitchCase();                     \\UC4
            //SwitchCase.Switchcase();
            //Console.ReadLine();

            MonthlyWage monthlywage = new MonthlyWage();                   
            MonthlyWage.EmployeeMonthlyWage();
            Console.ReadLine(); 

            TotalDaysHours totaldayshours = new TotalDaysHours();
            TotalDaysHours.DaysHoursOfMonth();
            Console.ReadLine();


        }
    }
}
