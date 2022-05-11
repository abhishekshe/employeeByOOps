using System;

namespace EmployeeWageComputation
{
    class ComputeEmployeeWage
    {
        public const int PartTime = 1;
        public const int FullTime = 2;

        public static int ComputeEmpWage(string compony, int empRatePerHr, int numOfWorkingDays, int maxHrPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= maxHrPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case PartTime:
                        empHrs = 4;
                        break;
                    case FullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs:" + empHrs);


            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total Emp for compony:" + compony + "is" + totalEmpWage);
            return totalEmpWage;


        }

    }
}