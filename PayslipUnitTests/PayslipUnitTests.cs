using PayslipKata001;
using Xunit;

namespace PayslipUnitTests
{
    public class PayslipUnitTests
    {
        [Fact]
        public void ShouldCalculateCorrectlyFact()
        {
            //Act
            var result = Calculate.GrossPayPeriodIncome(60050);
            //Arrange
            //Assert
            Assert.Equal(5004, result);
        }

        [Theory]
        [InlineData(60050, 12, 5004)]
        /*[InlineData()]
        [InlineData()]
        [InlineData()]*/
        public void ShouldCalculateGrossPayCorrectlyTheory(double grossAnnualPay, double payPeriodsPerYear, int outputGrossPay)
        {
            //Act
            var result = Calculate.GrossPayPeriodIncome(grossAnnualPay);
            //Arrange
            //Assert
            Assert.Equal(outputGrossPay, result);
        }

        [Fact]
        public void ShouldReturnGrossTaxableValueCorrectlyFact()
        {
            //Act
            var result = Calculate.GrossAnnualTaxableValue(40000, 37000);
            //Arrange
            //Assert
            Assert.Equal(3000, result);
        }

        [Theory]
        [InlineData(100000, 87000, 13000)]
        [InlineData(20000, 0, 20000)]
        [InlineData(80000, 37000, 43000)]
        [InlineData(200000, 180000, 20000)]
        public void ShouldReturnGrossTaxableValueCorrectlyTheory(double grossAnnualPay, double previousTaxBracketLimit,
            double actual)
        {
            //Act
            var result = Calculate.GrossAnnualTaxableValue(grossAnnualPay, previousTaxBracketLimit);
            //Arrange
            //Assert
            Assert.Equal(actual, result);
        }
    }
}