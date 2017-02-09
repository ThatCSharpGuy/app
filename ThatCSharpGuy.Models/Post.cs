using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ThatCSharpGuy.Models
{
	using ModelsPreserve;

		[Preserve]
    public class Post
    {

		[Preserve]
		public Post()
		{

		}
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Summary { get; set; }
        [JsonProperty("featured_image")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featured_tag")]
        public string FeaturedTag { get; set; }

		public string id { get; set; }
		public bool tv { get; set; }
		public string author { get; set; }
    }
}
