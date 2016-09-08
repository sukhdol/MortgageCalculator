using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.ViewModels
{
    public class LoanFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Mortgage Amount is required.")]
        public double? MortgageAmount { get; set; }

        [Required(ErrorMessage = "The Annual Interest Rate is required.")]
        public double? AnnualInterestRate { get; set; }

        [Required(ErrorMessage = "The Amortization Period is required.")]
        public int? AmortizationPeriod { get; set; }

        public double MonthlyPayment { get; set; }
    }
}