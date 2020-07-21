using Core.Entidades;
using Core.Enums;
using FluentValidation;

namespace Core.Validadores
{
    public sealed class WorkflowValidador : AbstractValidator<Workflow>
    {
        public WorkflowValidador()
        {
            RuleFor(t => t.StepCorrente).IsInEnum();

            RuleFor(t => t.Apresentante).NotEmpty().SetValidator((workflow) =>
            {
                return new ApresentanteValidador(workflow.StepCorrente);
            }, default);
        }
    }
}