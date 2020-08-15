using PayslipKata001;
using Xunit;

namespace PayslipUnitTests
{
    public class BracketUnitTests
    {
        [Fact]
        public void ShouldProvideTaxPercentCorrectlyFact()
        {
            //Act
            var result = Bracket.TaxPercent(20000);
            //Arrange
            //Assert
            Assert.Equal(19, result);
        }

        [Theory]
        [InlineData(40000, 32.5)]
        [InlineData(200000, 45)]
        [InlineData(100000, 37)]
        [InlineData(10000, 0)]
        public void ShouldProvideTaxPercentCorrectlyTheory(double grossPay, double expected)
        {
            //Act
            var result = Bracket.TaxPercent(grossPay);
            //Arrange
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldProvideMinimumTaxAmountCorrectlyFact()
        {
            //Act
            var result = Bracket.MinimumTaxAmount(50000);
            //Arrange
            //Assert
            Assert.Equal(3572, result);
        }

        [Theory]
        [InlineData(120000, 19822)]
        [InlineData(200000, 54232)]
        [InlineData(10000, 0)]
        [InlineData(25000, 0)]
        public void ShouldProvideMinimumTaxAmountCorrectlyTheory(double grossPay, double expected)
        {
            //Act
            var result = Bracket.MinimumTaxAmount(grossPay);
            //Arrange
            //Assert
            Assert.Equal(expected, result);
        }
    }
}