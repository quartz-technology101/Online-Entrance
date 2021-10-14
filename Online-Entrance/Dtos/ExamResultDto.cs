using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Entrance.Dtos
{
    public class ExamResultDto
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }


        [Required]
        public string Question { get; set; }

        [Required]
        public string UserInput { get; set; }


        [Required]
        public string TopicName { get; set; }

        public bool IsCorrect { get; set; }
    }
}