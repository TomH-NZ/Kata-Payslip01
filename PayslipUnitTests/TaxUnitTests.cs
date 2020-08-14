using System;
using PayslipKata001;
using Xunit;

namespace PayslipUnitTests
{
    public class TaxUnitTests
    {
        [Fact]
        public void ShouldCalculateCorrectly()
        {
            //Arrange
            var calculatedTax = Tax.Calculator(3572, 60050, 37000, 32.5, 12);
            //Act
            //Assert
            Assert.Equal(922, calculatedTax);
        }

        [Theory]
        [InlineData(3572, 60050, 37000, 32.5, 12, 922)]
        /*[InlineData()]
        [InlineData()]
        [InlineData()]*/
        public void ShouldCalculateTaxCorrectly(double previousTaxAmount, double grossIncome, double previousTaxBracketLimit,
            double taxPercentage, double payPeriodsPerYear, int outputTaxValue)
        {
            //Arrange
            var taxCalculated = Tax.Calculator(previousTaxAmount, grossIncome, previousTaxBracketLimit, taxPercentage,
                payPeriodsPerYear);
            //Act
            //Assert
            Assert.Equal(outputTaxValue, taxCalculated);
        }
    }
}