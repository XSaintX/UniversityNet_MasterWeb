using MasterNet.Application.Cursos.CursoCreate;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;

namespace MasterNet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ISender _sender;
        public CursosController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Guid>> CursoCreate([FromForm] CursoCreateRequest request, CancellationToken cancellationToken)
        {
            var command = new CursoCreateCommandRequest(request);
            var resultado = await _sender.Send(command, cancellationToken);
            return Ok(resultado);
        }
    }
}
