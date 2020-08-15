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
            Console.WriteLine();

            var grossIncome = Payslip.GrossPayPeriodValueCalculator(grossSalary);
            var incomeTax = Tax.Calculator(Bracket.MinimumTaxAmount(grossSalary),
                Payslip.GrossTaxableValueCalculator(grossSalary, Bracket.PreviousTaxBracketLimit(grossSalary)),
                Bracket.TaxPercent(grossSalary));
            var netIncome = grossIncome - incomeTax;
            var superannuationAmount = Superannuation.Calculator(Convert.ToDouble(grossIncome), superannuationRate);

            Console.WriteLine("Your payslip is: \n");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Pay Period: {startDate} to {endDate}");
            Console.WriteLine($"Gross Income: {grossIncome}");
            Console.WriteLine($"Income Tax: {incomeTax}");
            Console.WriteLine($"Net Income: {netIncome}");
            Console.WriteLine($"Superannuation: {superannuationAmount}");
            Console.ReadLine();
        }
    }
}