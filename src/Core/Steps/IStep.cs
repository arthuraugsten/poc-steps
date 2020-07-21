using Core.Entidades;
using Core.Enums;

namespace Core.Steps
{
    public interface IStep
    {
        ESteps StepCorrente { get; }
        ESteps ProximoStep { get; }

        void Avancar(Workflow workflow);
    }
}