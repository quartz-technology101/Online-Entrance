using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Online_Entrance.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Online_Entrance.Controllers.Api
{
    [Authorize(Roles = "CanManageQuestions")]
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> UserManager { get; set; }

        public UsersController()
        {
            this._context=new ApplicationDbContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this._context));
        }
        //GET /api/users
        public IEnumerable<ApplicationUser> GetUsers()
        {
            var users = UserManager.Users.ToList();
            return users.OrderBy(u=>u.UserName);
            
        }

    }
}
