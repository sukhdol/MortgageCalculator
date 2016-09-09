using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculator.Models;

namespace MortgageCalculator.Tests
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void IsGetMonthlyPaymentGivingCorrectResult1()
        {
            var loan = new Loan
            {
                MortgageAmount = 250000,
                AnnualInterestRate = 5.29,
                AmortizationPeriod = 25
            };

            var result = loan.GetMonthlyPayment();

            Assert.AreEqual(1495.56, result);
        }

        [TestMethod]
        public void IsGetMonthlyPaymentGivingCorrectResult2()
        {
            var loan = new Loan
            {
                MortgageAmount = 250000,
                AnnualInterestRate = 3.09,
                AmortizationPeriod = 25
            };

            var result = loan.GetMonthlyPayment();

            Assert.AreEqual(1194.69, result);
        }

        [TestMethod]
        public void IsGetMonthlyPaymentGivingCorrectResult3()
        {
            var loan = new Loan
            {
                MortgageAmount = 250000,
                AnnualInterestRate = 5.29,
                AmortizationPeriod = 20
            };

            var result = loan.GetMonthlyPayment();

            Assert.AreEqual(1682.18, result);
        }
    }
}
