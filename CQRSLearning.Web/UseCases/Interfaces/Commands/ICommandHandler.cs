namespace CQRSLearning.Web.UseCases.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
