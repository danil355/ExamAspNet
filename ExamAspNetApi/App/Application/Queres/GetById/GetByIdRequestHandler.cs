using AutoMapper;
using Domain.Model;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Queres.GetById
{
    public class GetByIdRequestHandler : IRequestHandler<GetByIdRequest, ApplicationDTO>
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public GetByIdRequestHandler(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationDTO> Handle(GetByIdRequest request, CancellationToken cancellationToken)
        {
            var app = _applicationRepository.GetById(request.ApplicationId);
            return  _mapper.Map<ApplicationDTO>(app);
        }
    }
}
