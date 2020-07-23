using AutoMapper;
using Edu.Application.DTO;
using ExamAspNetApi.App.Application.Commands.Create;
using ExamAspNetApi.App.Application.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.Profiles
{
    public class CommandToDTO : Profile
    {
        public CommandToDTO()
        {
            CreateMap<CreateApplicationRequest, ApplicationDTO>();
            CreateMap<UpdateApplicationCommand, ApplicationDTO>();
        }
    }
}
