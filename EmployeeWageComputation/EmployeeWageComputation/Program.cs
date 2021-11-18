using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program.");
            EmpWageBuilder infosys = new EmpWageBuilder("Infosys", 10, 50, 200);
            EmpWageBuilder wipro = new EmpWageBuilder("Wipro", 30, 54, 150);
            infosys.computeEmpWage();
            Console.WriteLine(infosys.toString());
            wipro.computeEmpWage();
            Console.WriteLine(wipro.toString());
        }
    }
}