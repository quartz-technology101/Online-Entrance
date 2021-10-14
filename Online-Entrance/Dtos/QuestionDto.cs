using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Entrance.Dtos
{
    public class QuestionDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string QuestionSentence { get; set; }

        [Required]
        [StringLength(255)]
        public string Option1 { get; set; }

        [Required]
        [StringLength(255)]
        public string Option2 { get; set; }

        [Required]
        [StringLength(255)]
        public string Option3 { get; set; }

        [Required]
        [StringLength(255)]
        public string Option4 { get; set; }

        [Required]
        [StringLength(255)]
        public string CorrectAnswer { get; set; }

        public TopicDto Topic { get; set; }

        public int TopicId { get; set; }

        //public FacultyDto Faculty { get; set; }

        //public int FacultyId { get; set; }
    }
}