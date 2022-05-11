using System;

namespace EmployeeWageComputation
{
    class ComputeEmployeeWage
    {
        const int IS_PRESENT = 1;
        const int IS_PART_TIME = 2;
        public void CalculateMonthlyWage()
        {
            int wagePerHour = 20;
            int fullDayHour;
            int workDayCount = 0;
            int noOfWorkingDays = 20;
            int hoursPerMonth = 100;
            int totalWorkingHours = 0;
            int totalDailyWage;
            int monthlyWage;

            while (workDayCount < noOfWorkingDays && totalWorkingHours <= hoursPerMonth)
            {
                Random random = new Random();
                int checkIfPresent = random.Next(0, 3);
                
                ComputeEmployeeWage computeEmployeeWage = new ComputeEmployeeWage();
                fullDayHour = computeEmployeeWage.WorkHours(checkIfPresent, workDayCount);
                if (totalWorkingHours + fullDayHour > hoursPerMonth)
                {
                    fullDayHour = 0;
                }
                totalWorkingHours += fullDayHour;
                totalDailyWage = fullDayHour * wagePerHour;
                Console.WriteLine($"Total daily wage is for {workDayCount + 1} is {totalDailyWage}");
                workDayCount++;
                
            }
            monthlyWage = totalWorkingHours * wagePerHour;
           ;
            Console.WriteLine("The monthly wage of an employee is " + monthlyWage);
        }
       
        public int WorkHours(int checkIfPresent, int workDayCount)
        {
            switch (checkIfPresent)
            {
                case IS_PRESENT:
                    Console.WriteLine($"Employee is present on {workDayCount + 1} day.");
                    
                    return 8;
                case IS_PART_TIME:
                    Console.WriteLine($"Employee is present for part time on {workDayCount + 1} day.");
                  
                    return 4;
                default:
                    Console.WriteLine($"Employee is Absent on {workDayCount + 1}");
                  
                    return 0;
            }
        }
    }
}