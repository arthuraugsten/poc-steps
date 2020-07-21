using Core.Entidades;
using Core.Enums;
using Core.Validadores;
using FluentValidation;
using System;

namespace Core.Steps
{
    public abstract class StepBase : IStep
    {
        protected IValidator<Workflow> Validador { get; }

        protected StepBase(IValidator<Workflow> validador)
            => Validador = validador;

        public abstract ESteps StepCorrente { get; }
        public abstract ESteps ProximoStep { get; }

        public void Avancar(Workflow workflow)
        {
            if (workflow.StepCorrente != StepCorrente)
                throw new ArgumentException(nameof(workflow.StepCorrente));

            Validador.ValidateAndThrow(workflow);

            workflow.AlterarStep(ProximoStep);
        }
    }
}