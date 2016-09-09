using System;
using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.ViewModels
{
    public class LoanFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Mortgage Amount is required.")]
        [Range(0.01, Double.MaxValue,
                    ErrorMessage = "The Mortgage Amount should be higher than 0.")]
        public double MortgageAmount { get; set; }

        [Required(ErrorMessage = "The Annual Interest Rate is required.")]
        [Range(0.01, Double.MaxValue,
                        ErrorMessage = "The Annual Interest Rate should be higher than 0.")]
        public double AnnualInterestRate { get; set; }

        [Required(ErrorMessage = "The Amortization Period is required.")]
        [Range(1, Int32.MaxValue,
                        ErrorMessage = "The Amortization Period should be higher than 0.")]
        public int AmortizationPeriod { get; set; }

        public double MonthlyPayment { get; set; }
    }
}