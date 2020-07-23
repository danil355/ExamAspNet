using AutoMapper;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Commands.Delete
{
    public class DeleteApplicationRequest : IRequest<ApplicationDTO> 
    {
        public int ApplicationId { get; set; }

        public DeleteApplicationRequest(int id)
        {
            ApplicationId = id;
        }


    }
}
