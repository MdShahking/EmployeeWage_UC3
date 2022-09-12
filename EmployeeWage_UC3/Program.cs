using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            Console.WriteLine("RAndom Vallue: " + empCheck);
            if (FULL_TIME == empCheck)
            {
                empHrs = 8;
                Console.WriteLine("Full time Employee is present");
            }
            else if (PART_TIME == empCheck)
            {
                empHrs = 4;
                Console.WriteLine("Part time Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage per day is " + empWage);
            Console.ReadLine();
        }
    }

}

