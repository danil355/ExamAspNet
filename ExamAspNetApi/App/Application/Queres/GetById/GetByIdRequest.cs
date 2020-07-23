using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Queres.GetById
{
    public class GetByIdRequest : IRequest<ApplicationDTO>
    {
        public int ApplicationId { get; set; }

        public GetByIdRequest(int id)
        {
            ApplicationId = id;
        }
    }
}
