using PayslipKata001;
using Xunit;

namespace PayslipUnitTests
{
    public class PayslipUnitTests
    {
        [Fact]
        public void ShouldCalculateCorrectly()
        {
            //Act
            var grossPay = Payslip.GrossPay(60050, 12);
            //Arrange
            //Assert
            Assert.Equal(5004, grossPay);
        }

        [Theory]
        [InlineData(60050, 12, 5004)]
        /*[InlineData()]
        [InlineData()]
        [InlineData()]*/
        public void ShouldCalculateGrossPayCorrectly(double annualGrossPay, double payPeriodsPerYear, int outputGrossPay)
        {
            var grossPay = Payslip.GrossPay(annualGrossPay, payPeriodsPerYear);
            Assert.Equal(outputGrossPay, grossPay);
        }
    }
}