using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSLearning.Web.Dtos
{
    public class BookNamesDto
    {
        public IEnumerable<string> Names { get; set; }
        public BookNamesDto()
        {
            Names = new List<string>();
        }
    }
}
