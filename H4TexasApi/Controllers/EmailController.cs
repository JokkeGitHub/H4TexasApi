using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace H4TexasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        [HttpPost]
        [Route("sendemail")]
        public IActionResult SendEmail()
        {
            var email = new MailMessage();
            email.From = new MailAddress("jokkesdummymail@gmail.com");
            email.To.Add("joac3146@zbc.dk");
            email.Subject = "Test Email Subject";
            email.Body = "Test Body";
            email.IsBodyHtml = false;

            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("jokkesdummymail@gmail.com", "annkmqtqqxvalncn");
            smtpClient.EnableSsl = true;

            smtpClient.Send(email);

            return Ok();
        }
    }
}
