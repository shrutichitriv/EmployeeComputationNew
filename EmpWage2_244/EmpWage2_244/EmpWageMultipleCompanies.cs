﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage2_244
{
    public class EmpWageMultipleCompanies
    {
        public string company;
        public int empRatePerHour;
        public int NUM_OF_WORKING_DAYS;
        public int MAX_HR_PER_MONTH;
        public int totalEmpWage;

        public EmpWageMultipleCompanies(string company, int empRatePerHour, int NUM_OF_WORKING_DAYS, int MAX_HR_PER_MONTH)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_HR_PER_MONTH = MAX_HR_PER_MONTH;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        private int num_of_Company = 0;
        private EmpWageMultipleCompanies[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new EmpWageMultipleCompanies[7];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int NUM_OF_WORKING_DAYS, int MAX_HR_PER_MONTH)
        {
            companyEmpWageArray[this.num_of_Company] = new EmpWageMultipleCompanies(company, empRatePerHour, NUM_OF_WORKING_DAYS, MAX_HR_PER_MONTH);
            num_of_Company++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < num_of_Company; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(EmpWageMultipleCompanies companyEmpWage)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= companyEmpWage.MAX_HR_PER_MONTH && totalWorkingDays < companyEmpWage.NUM_OF_WORKING_DAYS)
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
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
