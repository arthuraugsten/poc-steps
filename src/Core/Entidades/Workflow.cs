using Core.Enums;

namespace Core.Entidades
{
    public sealed class Workflow
    {
        public Workflow()
        { }

        public Workflow(ESteps stepCorrente)
            => StepCorrente = stepCorrente;

        public ESteps StepCorrente { get; set; }
        public Apresentante Apresentante { get; set; }

        public void AlterarStep(ESteps step) => StepCorrente = step;
    }
}