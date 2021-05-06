using CQRSLearning.Web.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSLearning.Web.Data
{
    public class FakeDbContext
    {
        public FakeDbContext()
        {
            Books = new()
            {
                new Book("c# in nutshell","yadam nist","ssass","sadasd",DateTime.Now),
                new Book("java in nutshell", "yadam nist", "ssass", "sadasd", DateTime.Now),
                new Book("javascript in nutshell", "yadam nist", "ssass", "sadasd", DateTime.Now),
                new Book("php in nutshell", "yadam nist", "ssass", "sadasd", DateTime.Now)

            };
        }
        public List<Book> Books { get; set; }
    }
}
