using CQRSLearning.Web.Data;
using CQRSLearning.Web.Dtos;
using CQRSLearning.Web.UseCases.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSLearning.Web.UseCases.Book.Queries
{
    public class ReadNameOfBooksQueryhandler : IRequestHandler<ReadNameOfBooksQuery, BookNamesDto>
    {
        private readonly FakeDbContext _ctx;

        public ReadNameOfBooksQueryhandler(FakeDbContext ctx)
        {
            this._ctx = ctx;
        }

        public Task<BookNamesDto> Handle(ReadNameOfBooksQuery request, CancellationToken cancellationToken)
        {
            var bookNames = new BookNamesDto()
            {
                Names = _ctx.Books.Select(c=>c.Title)
            };
            return Task.FromResult(bookNames);
        }
    }
}
