using Core.Enums;
using Core.Steps;

namespace Core.Strategies
{
    public interface IStepStrategy
    {
        IStep CriarServico(ESteps step);
    }
}