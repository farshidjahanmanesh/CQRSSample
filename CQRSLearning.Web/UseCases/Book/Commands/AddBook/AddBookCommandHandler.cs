using CQRSLearning.Web.Data;
using CQRSLearning.Web.UseCases.Interfaces;

namespace CQRSLearning.Web.UseCases.Book.Commands.AddBook
{
    public class AddBookCommandHandler : ICommandHandler<AddBookCommand>
    {
        private readonly FakeDbContext _ctx;

        public AddBookCommandHandler(FakeDbContext ctx)
        {
            this._ctx = ctx;
        }
        public void Execute(AddBookCommand command)
        {
            _ctx.Books.Add(new Domains.Book(command.Title, command.AuthorName, command.ReleaseTime));
        }
    }
}
