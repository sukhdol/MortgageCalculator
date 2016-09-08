namespace MortgageCalculator.ViewModels
{
    public class LoanFormViewModel
    {
        public double MortgageAmount { get; set; }
        public double AnnualInterestRate { get; set; }
        public int AmortizationPeriod { get; set; }
        public double MonthlyPayment { get; set; }
    }
}