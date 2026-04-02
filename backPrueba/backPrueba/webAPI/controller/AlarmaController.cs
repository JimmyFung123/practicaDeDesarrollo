using backPrueba.application.commands;
using backPrueba.application.queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace backPrueba.webAPI.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlarmaController: ControllerBase
    {
        private readonly IMediator _mediator;
        public AlarmaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Activar([FromBody] String emisor)
        {
            var command = new AlarmaComandos(emisor); 

            var idAlarma = await _mediator.Send(command);

            return Ok(new {id = idAlarma, mensaje = "Alarma Activada"});
        }

        [HttpGet]
        public async Task<IActionResult> obtenerAlarmas()
        {
            var query = new AlarmaQueries();
            var alarmas = await _mediator.Send(query);
            return Ok(alarmas);
        }

    }
}
