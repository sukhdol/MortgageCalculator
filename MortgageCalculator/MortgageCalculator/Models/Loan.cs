using System;
using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Mortgage Amount is required.")]
        public double MortgageAmount { get; set; }

        [Required(ErrorMessage = "The Annual Interest Rate is required.")]
        public double AnnualInterestRate { get; set; }

        [Required(ErrorMessage = "The Amortization Period is required.")]
        public int AmortizationPeriod { get; set; }

        public double MonthlyPayment { get; set; }

        public DateTime DateCalculated { get; set; }

        // Calculate the Mortgage Monthly Payment
        // Used in the Unit Test
        public double GetMonthlyPayment()
        {
            var interestRate = AnnualInterestRate;
            var mortgageAmount = MortgageAmount;
            var amortizationPeriod = AmortizationPeriod;

            // first calculation of the equation/formula
            // using BEDMAS from left to right (Parentheses first then exponent)
            // FORMULA: (1 + (annualInterestRate/200)) ^ (1/6)
            // this step is used twice in the equation (numerator and denominator)
            var firstEquationCalculation = Math.Pow((1 + (interestRate / 200.0)), (1.0 / 6.0));

            // second calculation of the equation/formula
            // FORMULA: (-12 * amortizationPeriod)
            // used in the denominator
            var denominatorExponent = (-12.0) * amortizationPeriod;

            // final calculation for the numerator
            // FORMULA: firstEquationCalculation - 1
            var numerator = firstEquationCalculation - 1;

            // final calculation for the denominator
            // FORMULA: 1 - (  firstEquationCalculation ^ denominatorExponent ) )
            var denominator = 1 - (Math.Pow(firstEquationCalculation, denominatorExponent));

            // final calculation of the formula
            // Formula: mortgageAmount * (numerator/denominator)
            var monthlyPayment = mortgageAmount * (numerator / denominator);

            return Math.Round(monthlyPayment * 100) / 100.0;
        }

    }
}