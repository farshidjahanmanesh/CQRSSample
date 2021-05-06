
using CQRSLearning.Web.Dtos;
using CQRSLearning.Web.UseCases.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSLearning.Web.UseCases.Book.Queries
{
    public class ReadNameOfBooksQuery : IRequest<BookNamesDto>
    {
    }
}
