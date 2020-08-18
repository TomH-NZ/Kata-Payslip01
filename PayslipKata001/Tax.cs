using System;

namespace PayslipKata001
{
    public static class Tax
    {
        public static double DeterminePercent(double grossPay)
        {
            if (grossPay >= 180001)
            {
                return 45;
            }
            if (grossPay >= 87001 && grossPay <= 180000)
            {
                return 37;
            }

            if (grossPay >= 37001 && grossPay <= 87000)
            {
                return 32.5;
            }
            if (grossPay >= 18201 && grossPay <= 37000)
            {
                return 19;
            }

            return 0;
        }

        public static double DetermineMinimumAmount(double grossPay)
        {
            if (grossPay >= 180001)
            {
                return 54232;
            }
            if (grossPay >= 87001 && grossPay <= 180000)
            {
                return 19822;
            }

            if (grossPay >= 37001 && grossPay <= 87000)
            {
                return 3572;
            }
            
            return 0;
        }

        public static double DeterminePreviousBracketLimit(double grossPay)
        {
            if (grossPay >= 180001)
            {
                return 180000;
            }
            if (grossPay >= 87001 && grossPay <= 180000)
            {
                return 87000;
            }

            if (grossPay >= 37001 && grossPay <= 87000)
            {
                return 37000;
            }
            
            return 0;
        }
    }
}
