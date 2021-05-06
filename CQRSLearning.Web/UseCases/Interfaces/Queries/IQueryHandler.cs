namespace CQRSLearning.Web.UseCases.Interfaces
{
    public interface IQueryHandler<TResult>
    {
        TResult Execute();
    }
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery
    {
        TResult Execute(TQuery command);
    }
}
