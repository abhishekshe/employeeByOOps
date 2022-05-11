using System;


namespace EmployeeWageComputation
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wage computation Program");
            ComputeEmployeeWage computeEmployeeWage = new ComputeEmployeeWage();
            computeEmployeeWage.CalculateMonthlyWage();

        }


    }
}