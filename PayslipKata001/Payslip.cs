using System;

namespace PayslipKata001
{
    public class Payslip
    {
        public static int GrossPayPeriodValueCalculator(double grossAnnualPay)
        {
            return Convert.ToInt32(Math.Round(grossAnnualPay / 12, MidpointRounding.AwayFromZero));
        }

        public static double GrossTaxableValueCalculator(double grossAnnualPay, double previousTaxBracketLimit)
        {
            return grossAnnualPay - previousTaxBracketLimit;
        }
        
        
    }
}