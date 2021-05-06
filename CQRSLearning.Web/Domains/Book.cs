using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSLearning.Web.Domains
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Authorname { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime ReleaseTime { get; set; }

        public Book(string title, string authorName, string image, string description, DateTime releaseTime)
        {
            this.Title = title;
            this.Authorname = authorName;
            this.ReleaseTime = releaseTime;
            this.Description = description;
            this.Image = image;
        }

        public Book(string title, string authorName, DateTime releaseTime)
        {
            this.Title = title;
            this.Authorname = authorName;
            this.ReleaseTime = releaseTime;
        }
    }
}
