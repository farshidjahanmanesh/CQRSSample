namespace CQRSLearning.Web.UseCases.Interfaces
{
    #region for CQRS without Any Library
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
    #endregion
}
