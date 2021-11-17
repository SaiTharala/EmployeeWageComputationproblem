using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program.");
            EmployeeWage.MonthlyEmployeeWage("Brand Factory", 50, 20, 130);
            EmployeeWage.MonthlyEmployeeWage("Dell Technologies", 90, 20, 150);
        }
    }
}