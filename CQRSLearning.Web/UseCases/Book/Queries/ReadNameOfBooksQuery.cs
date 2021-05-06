
using CQRSLearning.Web.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSLearning.Web.UseCases.Book.Queries
{
    public class ReadNameOfBooksQuery : IQuery
    {
        public string Name { get; set; }
    }
}
