using CQRSLearning.Web.Data;
using CQRSLearning.Web.Dtos;
using CQRSLearning.Web.UseCases.Interfaces;
using System.Linq;

namespace CQRSLearning.Web.UseCases.Book.Queries
{
    public class ReadNameOfBooksQueryhandler : IQueryHandler<BookNamesDto>
    {
        private readonly FakeDbContext _ctx;

        public ReadNameOfBooksQueryhandler(FakeDbContext ctx)
        {
            this._ctx = ctx;
        }
        public BookNamesDto Execute()
        {
            var bookTitles = _ctx.Books.Select(c => c.Title);
            return new BookNamesDto()
            {
                Names = bookTitles
            };
        }
    }
}
