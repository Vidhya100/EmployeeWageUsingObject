using EmployeeWageUsingObject;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            MultipleCompanies dMart = new MultipleCompanies("Dmart", 20, 2, 10);
            MultipleCompanies reliance = new MultipleCompanies("Reliance", 10, 4, 20);

            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());

            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}