using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage2_244
{
    public class RefactorCode
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HR_IN_MONTH = 100;

        public static int ComputeEmpWage()
        {
            //Variables
            int empHr = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHr = 0;

            while (totalEmpHr <= MAX_HR_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)//While Loop Condition
            {
                totalWorkingDays++;
                Random random = new Random();
                //computataion
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHr = totalEmpHr + empHr;//Formula Of Calculate TotalEmpHour
                Console.WriteLine("Day: " + totalWorkingDays + " Employee Hour is: " + empHr);
            }
            totalEmpWage = totalEmpHr * EMP_RATE_PER_HR;
            Console.WriteLine("Total Employee wage is: " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
