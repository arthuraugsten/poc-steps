using Core.Enums;
using Core.Steps;
using System.Collections.Generic;
using System.Linq;

namespace Core.Strategies
{
    public sealed class StepStrategy : IStepStrategy
    {
        private readonly IEnumerable<IStep> _steps;

        public StepStrategy(IEnumerable<IStep> steps)
            => _steps = steps;

        public IStep CriarServico(ESteps step)
            => _steps.SingleOrDefault(t => t.StepCorrente == step);
    }
};