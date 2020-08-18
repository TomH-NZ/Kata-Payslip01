using PayslipKata001;
using Xunit;

namespace PayslipUnitTests
{
    public class TaxUnitTests
    {
        [Fact]
        public void ShouldCalculateCorrectlyFact()
        {
            //Arrange
            var result = Tax.Calculate(3572, 23050, 32.5);
            //Act
            //Assert
            Assert.Equal(922, result);
        }

        [Theory]
        [InlineData(3572, 23050, 32.5, 922)]
        /*[InlineData()]
        [InlineData()]
        [InlineData()]*/
        public void ShouldCalculateTaxCorrectlyTheory(double previousTaxAmount, double taxableAmount,
            double taxPercentage, int outputTaxValue)
        {
            //Arrange
            var result = Tax.Calculate(previousTaxAmount, taxableAmount, taxPercentage);
            //Act
            //Assert
            Assert.Equal(outputTaxValue, result);
        }
    }
}