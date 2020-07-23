using AutoMapper;
using Domain.Model;
using Edu.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.Profiles
{
    public class DTOToEntityProfile : Profile
    {
        public DTOToEntityProfile()
        {
            CreateMap<Application, ApplicationDTO>();
        }
    }
}
