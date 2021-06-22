using AutoDevBox.Api.Models.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDevBox.Api.Controllers
{
    [ApiController, Route("[controller]")]
    public class SoftwareDetailController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<SoftwareDetailController> logger;

        public SoftwareDetailController(IMediator mediator, ILogger<SoftwareDetailController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpGet, ProducesResponseType(typeof(IReadOnlyCollection<SoftwareDetailQuery>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            object softwareDetails = await mediator.Send(new SoftwareDetailQuery());
            return Ok(softwareDetails);
        }
    }
}
