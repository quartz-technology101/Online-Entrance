using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Entrance.Dtos
{
    public class ExamGiverDto
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

    }
}