using System;

namespace MortgageCalculator.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public double MortgageAmount { get; set; }
        public double AnnualInterestRate { get; set; }
        public int AmortizationPeriod { get; set; }
        public double MonthlyPayment { get; set; }
        public DateTime DateCalculated { get; set; }
    }
}