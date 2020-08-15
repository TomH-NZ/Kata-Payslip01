using System;

namespace PayslipKata001
{
    public static class Payslip
    {
        public static int GrossPayPeriodValueCalculator(double annualGrossPay, double payPeriodsPerYear)
        {
            return Convert.ToInt32(Math.Round(annualGrossPay / payPeriodsPerYear, MidpointRounding.AwayFromZero));
        }

        public static double GrossTaxableValueCalculator(double annualGrossPay, double previousTaxBracketLimit)
        {
            return annualGrossPay - previousTaxBracketLimit;
        }
    }
}