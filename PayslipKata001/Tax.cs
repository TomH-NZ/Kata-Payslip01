using System;

namespace PayslipKata001
{
    public static class Tax
    {
        public static int Calculate(double previousBracketTaxAmount, double taxableAmount, double taxPercentage)
        {
            const double payPeriodsPerYear = 12;
            
            var taxAmount = Math.Round((previousBracketTaxAmount + taxableAmount * taxPercentage / 100) / payPeriodsPerYear, MidpointRounding.AwayFromZero);
            return Convert.ToInt32(taxAmount);
        }
    }
}
