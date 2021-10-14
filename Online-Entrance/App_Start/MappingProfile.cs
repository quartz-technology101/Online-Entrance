using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Online_Entrance.Models;
using Online_Entrance.Dtos;

namespace Online_Entrance.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Question, QuestionDto>();
            Mapper.CreateMap<QuestionDto, Question>();

            Mapper.CreateMap<Topic, TopicDto>();
            Mapper.CreateMap<TopicDto, Topic>();

            Mapper.CreateMap<ExamResult, ExamResultDto>();
            Mapper.CreateMap<ExamResultDto, ExamResult>();

            Mapper.CreateMap<Faculty, FacultyDto>();
            Mapper.CreateMap<FacultyDto, Faculty>();

            Mapper.CreateMap<ExamGiver, ExamGiverDto>();
            
        }
    }
}