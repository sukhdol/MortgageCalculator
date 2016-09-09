using MortgageCalculator.ViewModels;
using System.Web.Mvc;

namespace MortgageCalculator.Controllers
{
    public class LoansController : Controller
    {
        // Initialize Calculator Page
        // RETURN: LoanForm, LoanFormViewModel
        public ActionResult Index()
        {
            var viewModel = new LoanFormViewModel();

            return View("LoanForm", viewModel);
        }

        // Initialize Loan List Page
        [Authorize]
        public ActionResult LoanList()
        {
            if (!User.IsInRole("CanManageLoans"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}