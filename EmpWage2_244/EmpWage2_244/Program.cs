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

            
            TotalWageEachCompany Amazon = new TotalWageEachCompany("Amazon", 30, 25, 20);
            TotalWageEachCompany Infosys = new TotalWageEachCompany("Infosys", 25, 22, 29);
            Amazon.CompanyEmpWage();
            Console.WriteLine(Amazon.toString());
            Infosys.CompanyEmpWage();
            Console.Write(Infosys.toString());




        }
    }
}