using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public const int IS_PRESENT = 1, WAGE_PER_HR = 20, FULL_WORKING_HRS = 8;
        int totalEmpWage;
        public void DailyEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                this.totalEmpWage = FULL_WORKING_HRS * WAGE_PER_HR;
                Console.WriteLine("Employee is present");
                Console.WriteLine(this.totalEmpWage);
            }
            else
                Console.WriteLine("Employee is absent");
        }
    }
}

