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
    public class DeleteApplicationRequestHandler : IRequestHandler<DeleteApplicationRequest, ApplicationDTO>
    {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public DeleteApplicationRequestHandler(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }


        public async Task<ApplicationDTO> Handle(DeleteApplicationRequest request, CancellationToken cancellationToken)
        {
            var app = _applicationRepository.Delete(request.ApplicationId);
            return _mapper.Map<ApplicationDTO>(request);
        }
    }
}
