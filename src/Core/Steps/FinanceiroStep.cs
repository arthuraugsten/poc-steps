using Core.Entidades;
using Core.Enums;
using FluentValidation;

namespace Core.Steps
{
    public sealed class FinanceiroStep : StepBase, IFinanceiroStep
    {
        public FinanceiroStep(IValidator<Workflow> validador)
            : base(validador) { }

        public override ESteps StepCorrente => ESteps.Financeiro;
        public override ESteps ProximoStep => ESteps.Contato;
    }
}