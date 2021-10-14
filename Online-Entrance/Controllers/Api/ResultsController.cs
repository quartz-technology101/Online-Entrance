using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Online_Entrance.Models;
using Online_Entrance.Dtos;
using System.Data.Entity;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Online_Entrance.Controllers.Api
{
   
    public class ResultsController : ApiController
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> UserManager { get; set; }

        public ResultsController()
        {
            this._context=new ApplicationDbContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this._context));
        }
        [HttpPost]
        public IHttpActionResult SaveResult(ExamResultDto examResultDto)
        {

            var user = UserManager.FindById(User.Identity.GetUserId());

            var examGiver = new ExamGiver
            {
                UserName=user.UserName,
                FullName=user.FullName,
                SchoolName=user.SchoolName,
                Gpa=user.Gpa,
                Dob=user.Dob,
                ContactNumber=user.ContactNumber,
                GuardianName=user.GuardianName,
                GuardianContact=user.GuardianContact,
                Faculty=user.Faculty

            };



            var examResult = Mapper.Map<ExamResultDto, ExamResult>(examResultDto);
            examResult.SubmittedTime = DateTime.Now;
            _context.ExamResults.Add(examResult);

            _context.ExamGivers.Add(examGiver);
            _context.SaveChanges();

            return Ok();
        }


        //GET /api/results
        [Authorize(Roles = "CanManageQuestions")]
        public IHttpActionResult GetResult()
        {
            var examResults = _context.ExamResults.GroupBy(r => new { r.UserName, r.Question }).ToList();
            var finalResults = examResults.Select(r => r.First());
            var finalResults2 = finalResults.GroupBy(r => r.UserName);
            return Ok(finalResults2);
        }

        //GET /api/results
        //public IHttpActionResult GetResult(string query = null)
        //{
        //    var resultsQuery = _context.ExamResults;

        //    if (!String.IsNullOrWhiteSpace(query))
        //        resultsQuery = resultsQuery.Where(r => r.UserName.Contains(query));

        //    var resultDtos = resultsQuery
        //        .ToList()
        //        .Select(Mapper.Map<ExamResult, ExamResultDto>);
        //    return Ok(resultDtos);

        //}


    }
}
