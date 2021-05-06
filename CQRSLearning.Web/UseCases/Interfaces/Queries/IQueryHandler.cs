namespace CQRSLearning.Web.UseCases.Interfaces
{

    #region for CQRS without Any Library
    public interface IQueryHandler<TResult>
    {
        TResult Execute();
    }
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery
    {
        TResult Execute(TQuery command);
    }
    #endregion
}
