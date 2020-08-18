using System;

namespace PayslipKata001
{
    public static class Calculate
    {
        private const int PayPeriodsPerYear = 12;
        public static int Tax(double previousBracketTaxAmount, double taxableAmount, double taxPercentage)
        {
            var taxAmount = Math.Round((previousBracketTaxAmount + taxableAmount * taxPercentage / 100) / PayPeriodsPerYear, MidpointRounding.AwayFromZero);
            return Convert.ToInt32(taxAmount);
        }

        public static int Superannuation( double netIncome, double superannuationRate)
        {    
            return Convert.ToInt32(Math.Round(netIncome * superannuationRate / 100, MidpointRounding.AwayFromZero));
        }

        public static int GrossPayPeriodIncome(double grossAnnualPay)
        {
            return Convert.ToInt32(Math.Round(grossAnnualPay / PayPeriodsPerYear, MidpointRounding.AwayFromZero));
        }

        public static double GrossAnnualTaxableValue(double grossAnnualPay, double previousTaxBracketLimit)
        {
            return grossAnnualPay - previousTaxBracketLimit;
        }
    }
}