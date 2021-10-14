using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Entrance.Controllers
{   
    [Authorize(Roles="CanManageQuestions")]
    public class QuestionController : Controller
    {

        // GET: Question
        [Route("questions")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("questions/new")]
        public ActionResult New()
        {
            return View("QuestionForm");
        }
    }
}