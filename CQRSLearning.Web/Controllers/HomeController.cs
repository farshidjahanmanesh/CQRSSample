
using CQRSLearning.Web.Dtos;
using CQRSLearning.Web.Models;
using CQRSLearning.Web.UseCases.Book.Commands.AddBook;
using CQRSLearning.Web.UseCases.Book.Queries;
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
        public IActionResult Index([FromServices] ReadNameOfBooksQueryhandler handler)
        {
            var listOfBookNames = handler.Execute();
            return View(listOfBookNames);
        }

        public IActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook([FromServices]AddBookCommandHandler handler,CreateBookDto book)
        {
            handler.Execute(new AddBookCommand(book.Title, book.AuthorName, DateTime.Now));
            return RedirectToAction("index", "home");
        }
    }
}
