using Core.Entidades;
using Core.Enums;
using FluentValidation;

namespace Core.Steps
{
    public sealed class DadosBasicosStep : StepBase, IDadosBasicosStep
    {
        public DadosBasicosStep(IValidator<Workflow> validador)
            : base(validador) { }

        public override ESteps StepCorrente => ESteps.DadosBasicos;
        public override ESteps ProximoStep => ESteps.Financeiro;
    }
}