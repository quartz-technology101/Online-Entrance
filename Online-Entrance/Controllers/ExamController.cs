using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using Online_Entrance.Models;
using Online_Entrance.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Online_Entrance.Controllers
{
    public class ExamController : Controller
    {

        protected ApplicationDbContext ApplicationDbContext;
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public ExamController()
        {
            this.ApplicationDbContext=new ApplicationDbContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.ApplicationDbContext));
        }

        [Route("exam/faculty")]
        public ActionResult Faculty()
        {
            return View();
        }

        

        [Route("exam/computerscience")]
        public ActionResult Computer()
        {
            return View("Computer");
        }

        [Route("exam/biology")]
        public ActionResult Biology()
        {
            return View("Biology");
        }

        [Route("exam/management")]
        public ActionResult Management()
        {
            return View("Management");
        }



        [HttpPost]
        public ActionResult SendMail(MailViewModel mailTableViewModel)
        {

            MailMessage message = new MailMessage("kodaayush@gmail.com", "aayushsapkota115@outlook.com");
            var userName = User.Identity.Name;
            var user = UserManager.FindById(User.Identity.GetUserId());
            var userEmail = user.Email;
            message.Subject = userEmail + " Entrance Report";
            message.Body = mailTableViewModel.Content;
            message.IsBodyHtml = true;

            var action = "computer";

        // The important part -- configuring the SMTP client
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;   // [1] You can try with 465 also.
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential("kodaayush@gmail.com", "yourPassword");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = nc;
             smtp.Send(message);

            return RedirectToAction(action);

        }
    }
}