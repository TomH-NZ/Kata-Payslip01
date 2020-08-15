using System;

namespace PayslipKata001
{
    public static class Tax
    {
        public static int Calculator(double previousTaxAmount, double taxableAmount, double taxPercentage)
        {
            const double payPeriodsPerYear = 12;
            
            var taxAmount = Math.Round((previousTaxAmount + taxableAmount * taxPercentage / 100) / payPeriodsPerYear, MidpointRounding.AwayFromZero);
            return Convert.ToInt32(taxAmount);
        }
    }
}

//ToDo: (grossIncome - previousTaxBracketLimit) passed as a single value from payslip? 