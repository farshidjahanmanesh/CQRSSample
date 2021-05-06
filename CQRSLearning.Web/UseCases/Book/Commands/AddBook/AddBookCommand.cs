
using CQRSLearning.Web.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSLearning.Web.UseCases.Book.Commands.AddBook
{
    public class AddBookCommand : ICommand
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
