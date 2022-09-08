using Application.Command.Usuario.AddUsuario;
using Application.Command.Usuario.DeleteUsuario;
using Application.Command.Usuario.UpdateUsuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Query.Usuario.GetUsuarioBasicInfo;
namespace API.Mediator.Controllers
{
    [ApiController]
    [Route("user")]
    public class UsuarioController : ControllerBase
    {
        private IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddUsuario([FromBody] AddUsuarioCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> UpdateUsuario([FromBody] UpdateUsuarioCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult> DeleteUsuario([FromBody] DeleteUsuarioCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("getBasic/{idUsuario}")]
        public async Task<ActionResult> GetUsuarioBasic(int idUsuario)
        {
            var result = await _mediator.Send(new GetUsuarioBasicInfoQuery(idUsuario));
            return Ok(result);
        }
    }
}
