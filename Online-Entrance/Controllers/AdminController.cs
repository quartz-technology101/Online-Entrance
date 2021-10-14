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
    [Authorize(Roles = "CanManageQuestions")]
     public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> UserManager { get; set; }

        public AdminController()
        {
            this._context=new ApplicationDbContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this._context));
        }

        [Route("admin/dashboard")]
        public ActionResult Dashboard()
        {
            return View();
        }
    
        [Route("users")]
        public ActionResult Users()
        {
            return View();
        }

        //[Route("users2")]
        //public ActionResult Users2()
        //{
        //    var users = UserManager.Users.ToList();
        //    var viewModel = new UsersViewModel()
        //    {
        //        Users = users
        //    };

           

        //    return View(users);
        //}
        //[Route("results/{username}")]
        public ActionResult Result(string username)
        {
            var examResults = _context.ExamResults.Where(r => r.UserName == username).GroupBy(r => r.Question).ToList();
            var finalExamResults = examResults.Select(r => r.First());
            
            return View(finalExamResults);
        }

        [Route("results")]
        public ActionResult AllResult()
        {
            var examGivers = _context.ExamGivers.GroupBy(u=>u.UserName).ToList();
            var examGivers2 = examGivers.Select(u => u.First());
            return View(examGivers2);
        }
    }
}