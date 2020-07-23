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

namespace ExamAspNetApi.App.Application.Commands.Create
{
    public class CreateApplicationRequestHandler : IRequestHandler<CreateApplicationRequest, ApplicationDTO>
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public CreateApplicationRequestHandler(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationDTO> Handle(CreateApplicationRequest request, CancellationToken cancellationToken)
        {
            var app = new Domain.Model.Application()
            {
                Id = request.Id,
                College = request.College,
                IIN = request.IIN,
                Profile1 = request.Profile1,
                Profile2 = request.Profile2,
                Score = request.Score
            };
            _applicationRepository.Create(app);
            var appl = _mapper.Map<ApplicationDTO>(request);
            return appl;
        }
    }
}
