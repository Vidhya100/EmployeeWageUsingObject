using EmployeeWageUsingObject;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            Refractor checkEployee = new Refractor();
            checkEployee.CalculateWages();
            checkEployee.CheckEmployeeAttendence();
        }
    }
}