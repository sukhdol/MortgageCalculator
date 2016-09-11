using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculator.Models;
using System.Linq;

namespace MortgageCalculator.Tests
{
    [TestClass]
    public class LoanScheduleTest
    {
        [TestMethod]
        public void IsGetLoanSchedulesGivingCorrectResult1()
        {
            var loan = new Loan
            {
                MortgageAmount = 1000,
                AnnualInterestRate = 10,
                AmortizationPeriod = 1
            };

            loan.MonthlyPayment = loan.GetMonthlyPayment();

            Assert.AreEqual(87.82, loan.MonthlyPayment);

            var loanSchedule = new LoanSchedule();

            var loanList = loanSchedule.GetLoanSchedules(loan);

            var loanSchedule1 = loanList.ElementAt(0);

            Assert.AreEqual(1, loanSchedule1.PaymentNumber);
            Assert.AreEqual(8.16, loanSchedule1.InterestPaid);
            Assert.AreEqual(79.66, loanSchedule1.PrincipalPaid);
            Assert.AreEqual(920.34, loanSchedule1.RemainingBalance);

            var loanSchedule2 = loanList.ElementAt(1);

            Assert.AreEqual(2, loanSchedule2.PaymentNumber);
            Assert.AreEqual(7.51, loanSchedule2.InterestPaid);
            Assert.AreEqual(80.31, loanSchedule2.PrincipalPaid);
            Assert.AreEqual(840.03, loanSchedule2.RemainingBalance);

            var loanSchedule6 = loanList.ElementAt(5);

            Assert.AreEqual(6, loanSchedule6.PaymentNumber);
            Assert.AreEqual(4.86, loanSchedule6.InterestPaid);
            Assert.AreEqual(82.96, loanSchedule6.PrincipalPaid);
            Assert.AreEqual(512.20, loanSchedule6.RemainingBalance);

            var loanSchedule7 = loanList.ElementAt(6);

            Assert.AreEqual(7, loanSchedule7.PaymentNumber);
            Assert.AreEqual(4.18, loanSchedule7.InterestPaid);
            Assert.AreEqual(83.64, loanSchedule7.PrincipalPaid);
            Assert.AreEqual(428.56, loanSchedule7.RemainingBalance);

            var loanSchedule11 = loanList.ElementAt(10);

            Assert.AreEqual(11, loanSchedule11.PaymentNumber);
            Assert.AreEqual(1.42, loanSchedule11.InterestPaid);
            Assert.AreEqual(86.40, loanSchedule11.PrincipalPaid);
            Assert.AreEqual(87.13, loanSchedule11.RemainingBalance);

            var loanSchedule12 = loanList.ElementAt(11);

            Assert.AreEqual(12, loanSchedule12.PaymentNumber);
            Assert.AreEqual(0.71, loanSchedule12.InterestPaid);
            Assert.AreEqual(87.13, loanSchedule12.PrincipalPaid);
            Assert.AreEqual(0.00, loanSchedule12.RemainingBalance);
        }

        [TestMethod]
        public void IsGetLoanSchedulesGivingCorrectResult2()
        {
            var loan = new Loan
            {
                MortgageAmount = 5000,
                AnnualInterestRate = 5,
                AmortizationPeriod = 2
            };

            loan.MonthlyPayment = loan.GetMonthlyPayment();

            Assert.AreEqual(219.24, loan.MonthlyPayment);

            var loanSchedule = new LoanSchedule();

            var loanList = loanSchedule.GetLoanSchedules(loan);

            var loanSchedule1 = loanList.ElementAt(0);

            Assert.AreEqual(1, loanSchedule1.PaymentNumber);
            Assert.AreEqual(20.62, loanSchedule1.InterestPaid);
            Assert.AreEqual(198.62, loanSchedule1.PrincipalPaid);
            Assert.AreEqual(4801.38, loanSchedule1.RemainingBalance);

            var loanSchedule2 = loanList.ElementAt(1);

            Assert.AreEqual(2, loanSchedule2.PaymentNumber);
            Assert.AreEqual(19.80, loanSchedule2.InterestPaid);
            Assert.AreEqual(199.44, loanSchedule2.PrincipalPaid);
            Assert.AreEqual(4601.94, loanSchedule2.RemainingBalance);

            var loanSchedule23 = loanList.ElementAt(22);

            Assert.AreEqual(23, loanSchedule23.PaymentNumber);
            Assert.AreEqual(1.80, loanSchedule23.InterestPaid);
            Assert.AreEqual(217.44, loanSchedule23.PrincipalPaid);
            Assert.AreEqual(218.37, loanSchedule23.RemainingBalance);

            var loanSchedule24 = loanList.ElementAt(23);

            Assert.AreEqual(24, loanSchedule24.PaymentNumber);
            Assert.AreEqual(0.90, loanSchedule24.InterestPaid);
            Assert.AreEqual(218.37, loanSchedule24.PrincipalPaid);
            Assert.AreEqual(0.00, loanSchedule24.RemainingBalance);
        }

        [TestMethod]
        public void IsGetLoanSchedulesGivingCorrectResult3()
        {
            var loan = new Loan
            {
                MortgageAmount = 10000,
                AnnualInterestRate = 8.9,
                AmortizationPeriod = 10
            };

            loan.MonthlyPayment = loan.GetMonthlyPayment();

            Assert.AreEqual(125.27, loan.MonthlyPayment);

            var loanSchedule = new LoanSchedule();

            var loanList = loanSchedule.GetLoanSchedules(loan);

            var loanSchedule1 = loanList.ElementAt(0);

            Assert.AreEqual(1, loanSchedule1.PaymentNumber);
            Assert.AreEqual(72.83, loanSchedule1.InterestPaid);
            Assert.AreEqual(52.44, loanSchedule1.PrincipalPaid);
            Assert.AreEqual(9947.56, loanSchedule1.RemainingBalance);

            var loanSchedule2 = loanList.ElementAt(1);

            Assert.AreEqual(2, loanSchedule2.PaymentNumber);
            Assert.AreEqual(72.45, loanSchedule2.InterestPaid);
            Assert.AreEqual(52.82, loanSchedule2.PrincipalPaid);
            Assert.AreEqual(9894.74, loanSchedule2.RemainingBalance);

            var loanSchedule119 = loanList.ElementAt(118);

            Assert.AreEqual(119, loanSchedule119.PaymentNumber);
            Assert.AreEqual(1.80, loanSchedule119.InterestPaid);
            Assert.AreEqual(123.47, loanSchedule119.PrincipalPaid);
            Assert.AreEqual(124.29, loanSchedule119.RemainingBalance);

            var loanSchedule120 = loanList.ElementAt(119);

            Assert.AreEqual(120, loanSchedule120.PaymentNumber);
            Assert.AreEqual(0.91, loanSchedule120.InterestPaid);
            Assert.AreEqual(124.29, loanSchedule120.PrincipalPaid);
            Assert.AreEqual(0.00, loanSchedule120.RemainingBalance);
        }

        [TestMethod]
        public void IsGetLoanSchedulesGivingCorrectResult4()
        {
            var loan = new Loan
            {
                MortgageAmount = 300000,
                AnnualInterestRate = 5.390,
                AmortizationPeriod = 25
            };

            loan.MonthlyPayment = loan.GetMonthlyPayment();

            Assert.AreEqual(1812.01, loan.MonthlyPayment);

            var loanSchedule = new LoanSchedule();

            var loanList = loanSchedule.GetLoanSchedules(loan);

            var loanSchedule1 = loanList.ElementAt(0);

            Assert.AreEqual(1, loanSchedule1.PaymentNumber);
            Assert.AreEqual(1332.61, loanSchedule1.InterestPaid);
            Assert.AreEqual(479.40, loanSchedule1.PrincipalPaid);
            Assert.AreEqual(299520.60, loanSchedule1.RemainingBalance);

            var loanSchedule2 = loanList.ElementAt(1);

            Assert.AreEqual(2, loanSchedule2.PaymentNumber);
            Assert.AreEqual(1330.48, loanSchedule2.InterestPaid);
            Assert.AreEqual(481.53, loanSchedule2.PrincipalPaid);
            Assert.AreEqual(299039.07, loanSchedule2.RemainingBalance);

            var loanSchedule299 = loanList.ElementAt(298);

            Assert.AreEqual(299, loanSchedule299.PaymentNumber);
            Assert.AreEqual(15.99, loanSchedule299.InterestPaid);
            Assert.AreEqual(1796.02, loanSchedule299.PrincipalPaid);
            Assert.AreEqual(1804.55, loanSchedule299.RemainingBalance);

            var loanSchedule300 = loanList.ElementAt(299);

            Assert.AreEqual(300, loanSchedule300.PaymentNumber);
            Assert.AreEqual(8.02, loanSchedule300.InterestPaid);
            Assert.AreEqual(1804.55, loanSchedule300.PrincipalPaid);
            Assert.AreEqual(0.00, loanSchedule300.RemainingBalance);
        }

        [TestMethod]
        public void IsGetLoanSchedulesGivingCorrectResult5()
        {
            var loan = new Loan
            {
                MortgageAmount = 100000,
                AnnualInterestRate = 7.9,
                AmortizationPeriod = 20
            };

            loan.MonthlyPayment = loan.GetMonthlyPayment();

            Assert.AreEqual(822.37, loan.MonthlyPayment);

            var loanSchedule = new LoanSchedule();

            var loanList = loanSchedule.GetLoanSchedules(loan);

            var loanSchedule1 = loanList.ElementAt(0);

            Assert.AreEqual(1, loanSchedule1.PaymentNumber);
            Assert.AreEqual(647.75, loanSchedule1.InterestPaid);
            Assert.AreEqual(174.62, loanSchedule1.PrincipalPaid);
            Assert.AreEqual(99825.38, loanSchedule1.RemainingBalance);

            var loanSchedule2 = loanList.ElementAt(1);

            Assert.AreEqual(2, loanSchedule2.PaymentNumber);
            Assert.AreEqual(646.62, loanSchedule2.InterestPaid);
            Assert.AreEqual(175.75, loanSchedule2.PrincipalPaid);
            Assert.AreEqual(99649.63, loanSchedule2.RemainingBalance);

            var loanSchedule239 = loanList.ElementAt(238);

            Assert.AreEqual(239, loanSchedule239.PaymentNumber);
            Assert.AreEqual(10.55, loanSchedule239.InterestPaid);
            Assert.AreEqual(811.82, loanSchedule239.PrincipalPaid);
            Assert.AreEqual(817.14, loanSchedule239.RemainingBalance);

            var loanSchedule240 = loanList.ElementAt(239);

            Assert.AreEqual(240, loanSchedule240.PaymentNumber);
            Assert.AreEqual(5.29, loanSchedule240.InterestPaid);
            Assert.AreEqual(817.14, loanSchedule240.PrincipalPaid);
            Assert.AreEqual(0.00, loanSchedule240.RemainingBalance);
        }

        [TestMethod]
        public void IsGetLoanSchedulesGivingCorrectResult6()
        {
            var loan = new Loan
            {
                MortgageAmount = 250000,
                AnnualInterestRate = 5.19,
                AmortizationPeriod = 25
            };

            loan.MonthlyPayment = loan.GetMonthlyPayment();

            Assert.AreEqual(1481.17, loan.MonthlyPayment);

            var loanSchedule = new LoanSchedule();

            var loanList = loanSchedule.GetLoanSchedules(loan);

            var loanSchedule1 = loanList.ElementAt(0);

            Assert.AreEqual(1, loanSchedule1.PaymentNumber);
            Assert.AreEqual(1069.74, loanSchedule1.InterestPaid);
            Assert.AreEqual(411.43, loanSchedule1.PrincipalPaid);
            Assert.AreEqual(249588.57, loanSchedule1.RemainingBalance);

            var loanSchedule300 = loanList.ElementAt(299);

            Assert.AreEqual(300, loanSchedule300.PaymentNumber);
            Assert.AreEqual(6.31, loanSchedule300.InterestPaid);
            Assert.AreEqual(1474.86, loanSchedule300.PrincipalPaid);
            Assert.AreEqual(0.00, loanSchedule300.RemainingBalance);
        }
    }
}
