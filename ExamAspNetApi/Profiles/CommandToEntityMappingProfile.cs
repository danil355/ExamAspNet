using AutoMapper;
using Domain.Model;
using ExamAspNetApi.App.Application.Commands.Create;
using ExamAspNetApi.App.Application.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.Profiles
{
    public class CommandToEntityMappingProfile : Profile
    {
        public CommandToEntityMappingProfile()
        {
            CreateMap<CreateApplicationRequest, Application>();
            CreateMap<UpdateApplicationCommand, Application>();
        }
    }
}
