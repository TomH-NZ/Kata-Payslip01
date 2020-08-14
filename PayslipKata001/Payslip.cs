using System;

namespace PayslipKata001
{
    public class Payslip
    {
        public static int GrossPay(double annualGrossPay, double payPeriodsPerYear)
        {
            return Convert.ToInt32(Math.Round(annualGrossPay / payPeriodsPerYear, MidpointRounding.AwayFromZero));
        }
    }
}