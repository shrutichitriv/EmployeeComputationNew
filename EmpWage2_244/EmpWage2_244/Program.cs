namespace EmpWage2_244
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Employee Wage Computation Program");

            //EmpAttendance.EmployeeAttendance();

            //DailyWage.CheckDailyWage();

            //PartTimeWage.CheckPartTime();

            //UsingSwitchCase.CheckUsingSwitch();

            //WagesForMonth.CheckMonthWages();

            //WagesTillCondition.CheckWages();

            //RefactorCode.ComputeEmpWage();

            //MultipleCompany.ComputeEmpWage("TCS", 22, 25, 20);
            //MultipleCompany.ComputeEmpWage("Infosys", 15, 26, 24);


            //TotalWageEachCompany Amazon = new TotalWageEachCompany("Amazon", 30, 25, 20);
            //TotalWageEachCompany Infosys = new TotalWageEachCompany("Infosys", 25, 22, 29);
            //Amazon.CompanyEmpWage();
            //Console.WriteLine(Amazon.toString());
            //Infosys.CompanyEmpWage();
            //Console.Write(Infosys.toString());

            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("TCS", 20, 4, 150);
            //empWageBuilder.addCompanyEmpWage("Amazon", 25, 7, 200);
            //empWageBuilder.addCompanyEmpWage("Infosys", 23, 3, 100);
            //empWageBuilder.addCompanyEmpWage("Wipro", 28, 4, 160);
            //empWageBuilder.addCompanyEmpWage("Hansen", 15, 2, 180);
            //empWageBuilder.addCompanyEmpWage("Reliance", 25, 7, 240);
            //empWageBuilder.addCompanyEmpWage("Apple", 40, 5, 260);
            //empWageBuilder.computeEmpWage();

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("TechMahindra", 25, 7, 160);
            empWageBuilder.addCompanyEmpWage("LG", 23, 3, 100);
            empWageBuilder.addCompanyEmpWage("Wipro", 28, 4, 160);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for TechMahindra company : " + empWageBuilder.getTotalWage("TechMahindra"));



        }
    }
}