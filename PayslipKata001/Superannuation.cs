using System;

namespace PayslipKata001
{
    public class Superannuation
    {
        public static int Calculator( double netIncome, double superannuationRate)
        {
            var superannuationValue = (Math.Round(netIncome * superannuationRate / 100, MidpointRounding.AwayFromZero));
            return Convert.ToInt32(superannuationValue);
        }
    }
}