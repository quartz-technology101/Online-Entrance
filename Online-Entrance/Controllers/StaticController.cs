using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Entrance.Controllers
{
    [AllowAnonymous]
    public class StaticController : Controller
    {
        // GET: Static
        [Route("Thankyou")]
        public ActionResult Thankyou()
        {
            return View();
        }
       
        [Route("Note")]
        public ActionResult Note()
        {
            return View("Note");
        }
    }
}