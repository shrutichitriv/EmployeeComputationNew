using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage2_244
{
    public class TotalWageEachCompany
    {

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string Company;
        private int EMP_RATE_PER_HR;
        private int NUM_OF_WORKING_DAYS;
        private int MAX_HR_IN_MONTH;
        private int totalEmpWage;
        public TotalWageEachCompany(string Company, int EMP_RATE_PER_HR, int NUM_OF_WORKING_DAYS, int MAX_HR_IN_MONTH)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HR = EMP_RATE_PER_HR;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_HR_IN_MONTH = MAX_HR_IN_MONTH;
        }
        public void CompanyEmpWage()
        {
            //Variable
            int empHr = 0;
            int totalWorkingDays = 0;
            int totalEmpHr = 0;

            while (totalEmpHr <= MAX_HR_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                //computation
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
                totalEmpHr = totalEmpHr + empHr;
                Console.WriteLine("Day: " + totalWorkingDays + " Employee Hour is: " + empHr);
            }
            totalEmpWage = totalEmpHr * EMP_RATE_PER_HR;
            Console.WriteLine("Total Employee wage for Company: " + Company + " is: " + totalEmpWage);
        }
        public string toString()
        {
            return " Total Employee wage for Company: " + this.Company + " is: " + this.totalEmpWage;
        }
    }
}
