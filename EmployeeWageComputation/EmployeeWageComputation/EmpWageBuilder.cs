using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;
        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Employee Hours : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
        }
        public string toString()
        {
            return "The Total Employee Wage for Company " + this.company + " is " + this.totalEmpWage;
        }
    }
}
