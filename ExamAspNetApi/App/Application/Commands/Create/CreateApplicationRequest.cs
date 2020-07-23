using Domain.Model.ENUM;
using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Commands.Create
{
    public class CreateApplicationRequest : IRequest<ApplicationDTO>
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public int Score { get; set; }
        public College College { get; set; }
        public Profile Profile1 { get; set; }
        public Profile Profile2 { get; set; }
    }
}
