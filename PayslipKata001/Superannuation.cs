using System;

namespace PayslipKata001
{
    public static class Superannuation
    {
        public static int Calculator( double netIncome, double superannuationRate)
        {    
            return Convert.ToInt32(Math.Round(netIncome * superannuationRate / 100, MidpointRounding.AwayFromZero));
        }
    }
}