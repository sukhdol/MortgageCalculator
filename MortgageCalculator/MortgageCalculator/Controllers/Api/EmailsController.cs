using MortgageCalculator.Models;
using System.Web.Http;

namespace MortgageCalculator.Controllers.Api
{
    public class EmailsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult SendEmail(Email email)
        {
            var newEmail = new Email
            {
                RecipientEmail = email.RecipientEmail,
                Subject = email.Subject,
                Body = email.Body
            };

            newEmail.SendEmail();
            return Ok();
        } 

    }
}
