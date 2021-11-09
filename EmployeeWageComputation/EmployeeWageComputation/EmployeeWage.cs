using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, WAGE_PER_HR = 20, FULL_WORKING_HRS = 8, PART_WORKING_HRS = 4;
        int totalEmpWage, empHrs;
        public void Switchcasewage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    this.empHrs = FULL_WORKING_HRS;
                    Console.WriteLine("Employee worked Full time");
                    break;
                case IS_PART_TIME:
                    this.empHrs = PART_WORKING_HRS;
                    Console.WriteLine("Employee worked Half time");
                    break;
                default:
                    this.empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            Console.WriteLine(this.totalEmpWage = this.empHrs * WAGE_PER_HR);
        }
    }
}


