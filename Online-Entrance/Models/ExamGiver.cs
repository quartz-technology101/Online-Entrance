using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Entrance.Models
{
    public class ExamGiver
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string SchoolName { get; set; }

        public string Gpa { get; set; }

        public string Dob { get; set; }

        public string ContactNumber { get; set; }

        public string GuardianName { get; set; }

        public string GuardianContact { get; set; }

        public string Faculty { get; set; }

        //public ExamGiver()
        //{

        //}

        //public ExamGiver(string userName,string fullName,string schoolName,string gpa,
        //    string dob,string contactNumber,string guardianName,string guardianContact,string faculty)
        //{
        //    UserName = userName;
        //    FullName = fullName;
        //    SchoolName = schoolName;
        //    Gpa = gpa;
        //    Dob = dob;
        //    ContactNumber = contactNumber;
        //    GuardianName = guardianName;
        //    GuardianContact=guardianContact;
        //    Faculty = faculty;

        //}
    }
}