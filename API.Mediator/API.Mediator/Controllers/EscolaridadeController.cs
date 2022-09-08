using Application.Command.Escolaridade.UpdateEscolaridade;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Mediator.Controllers
{
    [ApiController]
    [Route("scholarity")]
    public class EscolaridadeController : ControllerBase
    {
        private IMediator _mediator;
        public EscolaridadeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        [Route("updateScholarityByUserId")]
        public async Task<ActionResult> UpdateEscolaridade([FromBody] UpdateEscolaridadeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
