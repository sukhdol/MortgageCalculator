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
    }
}