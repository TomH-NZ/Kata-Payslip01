using System;

namespace PayslipKata001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payslip generator. \n");
            Console.WriteLine("Please enter your name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Please enter your annual salary:");
            var grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your superannuation rate:");
            var superannuationRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the pay period start date:");
            var startDate = Console.ReadLine();
            Console.WriteLine("Please enter the pay period end date:");
            var endDate = Console.ReadLine();
        }
    }
}