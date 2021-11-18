using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program.");
            EmpBuildArrays empWageBuilder = new EmpBuildArrays();
            empWageBuilder.addCompanyEmpWage("Brandfactory", 20, 25, 156);
            empWageBuilder.addCompanyEmpWage("Trends", 20, 25, 180);
            empWageBuilder.computeEmpWage();
        }
    }
}