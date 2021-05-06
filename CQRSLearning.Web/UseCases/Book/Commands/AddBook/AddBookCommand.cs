

using MediatR;
using System;

namespace CQRSLearning.Web.UseCases.Book.Commands.AddBook
{
    public class AddBookCommand : IRequest
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime ReleaseTime { get; set; }
        public AddBookCommand()
        {

        }

        public AddBookCommand(string title, string authorName, DateTime releaseTime)
        {
            this.Title = title;
            this.AuthorName = authorName;
            this.ReleaseTime = releaseTime;
        }
    }
}
