using Core.Entidades;
using Core.Strategies;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class ApresentanteController : ControllerBase
    {
        private readonly IStepStrategy _stepStrategy;

        public ApresentanteController(IStepStrategy stepStrategy)
            => _stepStrategy = stepStrategy;

        [HttpPost("step/avancar")]
        public IActionResult PostAsync([FromBody] Workflow workflow)
        {
            var servico = _stepStrategy.CriarServico(workflow.StepCorrente);

            servico.Avancar(workflow);

            return Ok(workflow);
        }
    }
}