using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.Models
{
    public class LoanSchedule
    {
        [Key]
        public int PaymentNumber { get; set; }

        public double InterestPaid { get; set; }

        public double PrincipalPaid { get; set; }

        public double RemainingBalance { get; set; }

        // Used in the LoanSchedule Unit Test
        public IEnumerable<LoanSchedule> GetLoanSchedules(Loan loan)
        {
            var amortizationPeriod = loan.AmortizationPeriod;
            var interestRate = loan.AnnualInterestRate;

            // Calculate Monthly Percentage Rate
            // FORMULA: ((1 + (interestRate/200)) ^ (1/6)) - 1
            var monthlyPercentageRate = (Math.Pow((1 + (interestRate / 200.0)), (1.0 / 6.0))) - 1;

            var monthlyPayment = loan.MonthlyPayment;
            var remainingBalance = loan.MortgageAmount;

            // Calculate the total months in the Amortization Period 
            var length = 12 * amortizationPeriod;

            var loanList = new List<LoanSchedule>(length);

            for (var counter = 1; counter <= length; counter++)
            {
                var loanSchedule = new LoanSchedule();

                // Calculate Interest Paid for the month
                // FORMULA: monthlyPercentage * RemainingBalance
                var interestPaid = Math.Round((monthlyPercentageRate * remainingBalance) * 100) / 100.0;

                // Calculate Principal Paid for the month
                // FORMULA: monthlyPayment - interestPaid
                var principalPaid = Math.Round((monthlyPayment - interestPaid) * 100) / 100.0;

                if (remainingBalance < monthlyPayment)
                {
                    principalPaid = remainingBalance;
                }

                // Calculate Remaining Mortgage Balance
                // FORMULA: remainingBalance - principalPaid
                remainingBalance = Math.Round((remainingBalance - principalPaid) * 100) / 100.0;

                loanSchedule.PaymentNumber = counter;
                loanSchedule.InterestPaid = interestPaid;
                loanSchedule.PrincipalPaid = principalPaid;
                loanSchedule.RemainingBalance = remainingBalance;

                loanList.Insert(counter - 1, loanSchedule);
            }

            return loanList;
        }
    }
}