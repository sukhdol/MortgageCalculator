using MortgageCalculator.ViewModels;
using System.Web.Mvc;

namespace MortgageCalculator.Controllers
{
    public class LoansController : Controller
    {
        // Initialize Page
        // RETURN: LoanForm, LoanFormViewModel
        public ActionResult Index()
        {
            var viewModel = new LoanFormViewModel();

            return View("LoanForm", viewModel);
        }
    }
}