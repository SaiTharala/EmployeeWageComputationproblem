using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, WAGE_PER_HR = 20, FULL_WORKING_HRS = 8, PART_WORKING_HRS = 4;
        int totalEmpWage, empHrs = 0;
        public void parttimewage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                this.empHrs = FULL_WORKING_HRS;
                Console.WriteLine("Employee worked Full time");
            }
            if (empCheck == IS_PART_TIME)
            {
                this.empHrs = PART_WORKING_HRS;
                Console.WriteLine("Employee worked Part time");
            }
            Console.WriteLine(this.totalEmpWage = this.empHrs * WAGE_PER_HR);
        }
    }
}

