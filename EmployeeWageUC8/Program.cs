using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputeEmployeeWage computeEmployeeWage = new ComputeEmployeeWage();
            ComputeEmployeeWage.ComputeEmpWage("Dmat", 20, 2, 10);
            ComputeEmployeeWage.ComputeEmpWage("Reliance", 10, 4, 20);
        }

    }
}