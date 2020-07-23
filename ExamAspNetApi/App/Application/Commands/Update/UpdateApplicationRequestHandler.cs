using AutoMapper;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Commands.Update
{
    public class UpdateApplicationRequestHandler : IRequestHandler<UpdateApplicationRequest, ApplicationDTO>
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public UpdateApplicationRequestHandler(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationDTO> Handle(UpdateApplicationRequest request, CancellationToken cancellationToken)
        {
            var updateApp = new Domain.Model.Application()
            {
                Id = request.Command.Id,
                College = request.Command.College,
                IIN = request.Command.IIN,
                Profile1 = request.Command.Profile1,
                Profile2 = request.Command.Profile2,
                Score = request.Command.Score
            };
            var applicationStudent = _applicationRepository.Update(request.ApplicationId, updateApp);
            return _mapper.Map<ApplicationDTO>(request.Command);
        }
    }
}
