using System;

namespace PayslipKata001
{
    public static class Payslip
    {
        public static int GrossPayPeriodValueCalculator(double grossAnnualPay, double payPeriodsPerYear)
        {
            return Convert.ToInt32(Math.Round(grossAnnualPay / payPeriodsPerYear, MidpointRounding.AwayFromZero));
        }

        public static double GrossTaxableValueCalculator(double grossAnnualPay, double previousTaxBracketLimit)
        {
            return grossAnnualPay - previousTaxBracketLimit;
        }
    }
}