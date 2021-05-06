
using CQRSLearning.Web.Dtos;
using CQRSLearning.Web.UseCases.Book.Commands.AddBook;
using CQRSLearning.Web.UseCases.Book.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSLearning.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator mediator;

        public HomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var listOfBookNames = await mediator.Send(new ReadNameOfBooksQuery());
            return View(listOfBookNames);
        }

        public IActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(CreateBookDto book)
        {
            var bookCommand = new AddBookCommand(book.Title, book.AuthorName, DateTime.Now);
            mediator.Send(bookCommand);
            return RedirectToAction("index", "home");
        }
    }
}
