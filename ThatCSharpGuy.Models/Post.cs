using System;
using System.Collections.Generic;
using System.Text;

namespace ThatCSharpGuy.Models
{
    public class Post
    {
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Summary { get; set; }
        public string FeaturedImage { get; set; }
        public string FeaturedTag { get; set; }


    }
}
