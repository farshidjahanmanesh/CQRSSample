using CQRSLearning.Web.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSLearning.Web.UseCases.Book.Commands.AddBook
{
    public class AddBookCommandHandler : AsyncRequestHandler<AddBookCommand>
    {
        private readonly FakeDbContext _ctx;

        public AddBookCommandHandler(FakeDbContext ctx)
        {
            this._ctx = ctx;
        }

        protected override Task Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            _ctx.Books.Add(new Domains.Book(request.Title, request.AuthorName, request.ReleaseTime));
            return Task.CompletedTask;
        }
    }
}
