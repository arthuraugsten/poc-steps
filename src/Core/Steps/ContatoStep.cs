using Core.Entidades;
using Core.Enums;
using FluentValidation;

namespace Core.Steps
{
    public sealed class ContatoStep : StepBase, IContatoStep
    {
        public ContatoStep(IValidator<Workflow> validador)
            : base(validador) { }

        public override ESteps StepCorrente => ESteps.Contato;
        public override ESteps ProximoStep => ESteps.Concluido;
    }
}