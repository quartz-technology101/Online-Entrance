using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Entrance.ViewModels
{
    public class MailViewModel
    {
        [AllowHtml]
        public string Content { get; set; }
    }
}