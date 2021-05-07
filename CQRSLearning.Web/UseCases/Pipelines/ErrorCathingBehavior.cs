using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSLearning.Web.UseCases.Pipelines
{
    public class ErrorCatchingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> logger;

        public ErrorCatchingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            this.logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            TResponse result = default;
            try
            {
                result = await next();
            }
            catch (Exception exception)
            {
                logger.LogError("error in :"+request.GetType().Name +Environment.NewLine+"error detail: "
                    +exception.Message+Environment.NewLine+"Data : "+exception.Data);
            }
            return result;
        }
    }
}
