using MortgageCalculator.Models;
using System;
using System.Web.Http;

namespace MortgageCalculator.Controllers.Api
{
    public class LoansController : ApiController
    {
        private ApplicationDbContext _context;

        public LoansController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult AddLoan(Loan loan)
        {
            loan.DateCalculated = DateTime.Now;

            _context.Loans.Add(loan);
            _context.SaveChanges();

            return Ok();
        }

        [Authorize(Roles = "CanManageLoans")]
        public IHttpActionResult GetLoans()
        {
            var loans = _context.Loans;

            return Ok(loans);
        }
    }
}
