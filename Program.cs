using EmployeeWageUsingObject;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            //CheckEmployee checkEployee = new CheckEmployee();
            //checkEployee.CheckEmployeeAttendence();

            UsingSwitch usingSwitch = new UsingSwitch();
            usingSwitch.CheckEmployeeAttendence();
        }
    }
}