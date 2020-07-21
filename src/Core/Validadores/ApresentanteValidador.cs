using Core.Entidades;
using Core.Enums;
using FluentValidation;

namespace Core.Validadores
{
    public sealed class ApresentanteValidador : AbstractValidator<Apresentante>
    {
        public ApresentanteValidador(ESteps stepCorrente)
        {
            switch (stepCorrente)
            {
                case ESteps.Contato:
                    RuleFor(t => t.Contato).NotEmpty();
                    RuleFor(t => t.Financeiro).NotEmpty();
                    RuleFor(t => t.DadosBasicos).NotEmpty();
                    break;
                case ESteps.Financeiro:
                    RuleFor(t => t.Financeiro).NotEmpty();
                    RuleFor(t => t.DadosBasicos).NotEmpty();
                    break;
                default:
                    RuleFor(t => t.DadosBasicos).NotEmpty();
                    break;
            };
        }
    }
}