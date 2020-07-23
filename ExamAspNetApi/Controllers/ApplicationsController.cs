using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.DataAccess;
using Domain.Model;
using MediatR;
using System.Threading;
using ExamAspNetApi.App.Application.Queres.GetById;
using ExamAspNetApi.App.Application.Commands.Update;
using ExamAspNetApi.App.Application.Commands.Create;
using ExamAspNetApi.App.Application.Commands.Delete;
using Edu.Application.DTO;

namespace ExamAspNetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationDTO>> Get(int id, CancellationToken ct)
        {
            var request = new GetByIdRequest(id);
            var response = await _mediator.Send(request);

            return response;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateApplicationCommand command)
        {
            var request = new UpdateApplicationRequest(id, command);
            var response = await _mediator.Send(request);

            return Ok(response);


        }

        [HttpPost]
        public async Task<ActionResult<ApplicationDTO>> Post(CreateApplicationRequest command)
        {
            var response = await _mediator.Send(command);
            return response;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApplicationDTO>> Delete(int id)
        {
            var request = new DeleteApplicationRequest(id);
            var response = await _mediator.Send(request);
            return response;

        }
    }
}
