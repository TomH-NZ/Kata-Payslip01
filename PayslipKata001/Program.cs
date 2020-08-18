using System;

namespace PayslipKata001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payslip generator. \n");
            Console.WriteLine("Please enter your name:");
            var payslipFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            var payslipLastName = Console.ReadLine();
            Console.WriteLine("Please enter your annual salary:");
            var grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your superannuation rate:");
            var superannuationRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the pay period start date:");
            var payPeriodStartDate = Console.ReadLine();
            Console.WriteLine("Please enter the pay period end date:");
            var payPeriodEndDate = Console.ReadLine();
            Console.WriteLine();

            var grossIncome = Calculate.GrossPayPeriodIncome(grossSalary);
            var incomeTax = Calculate.Tax(Tax.DetermineMinimumAmount(grossSalary),
                Calculate.GrossAnnualTaxableValue(grossSalary, Tax.DeterminePreviousBracketLimit(grossSalary)),
                Tax.DeterminePercent(grossSalary));
            var netIncome = grossIncome - incomeTax;
            var superannuationAmount = Calculate.Superannuation(Convert.ToDouble(grossIncome), superannuationRate);

            Console.WriteLine("Your payslip is: \n");
            Console.WriteLine($"Name: {payslipFirstName} {payslipLastName}");
            Console.WriteLine($"Pay Period: {payPeriodStartDate} to {payPeriodEndDate}");
            Console.WriteLine($"Gross Income: {grossIncome}");
            Console.WriteLine($"Income Tax: {incomeTax}");
            Console.WriteLine($"Net Income: {netIncome}");
            Console.WriteLine($"Superannuation: {superannuationAmount}");
            Console.ReadLine();
            
        }
    }
}