using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Commands.Update
{
    public class UpdateApplicationRequest : IRequest<ApplicationDTO>
    {
        public int ApplicationId { get; set; }
        public UpdateApplicationCommand Command { get; set; }

        public UpdateApplicationRequest(int id, UpdateApplicationCommand command)
        {
            ApplicationId = id;
            Command = command;
        }
    }
}
