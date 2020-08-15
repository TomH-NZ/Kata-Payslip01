using PayslipKata001;
using Xunit;

namespace PayslipUnitTests
{
    public class SuperannuationUnitTests
    {
        [Fact]
        public void ShouldCalculateCorrectlyFact()
        {
            //Arrange
            var result = Superannuation.Calculator(200, 9);
            //Act
            //Assert
            Assert.Equal(18, result);
        }

        [Theory]
        [InlineData(100, 9, 9)]
        [InlineData(3500, 9, 315)]
        [InlineData(2500, 4, 100)]
        [InlineData(4000, 8, 320)]
        public void ShouldCalculateSuperannuationCorrectlyTheory(double netIncome, double superannuationRate, int superannuationValue)
        {
            //Arrange
            var result = Superannuation.Calculator(netIncome, superannuationRate);
            //Act
            //Assert
            Assert.Equal(superannuationValue, result);
        }
    }
}