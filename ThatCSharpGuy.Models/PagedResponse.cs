using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ThatCSharpGuy.Models
{
    public class PagedResponse<T>
    {
        public List<T> Items { get; set; }
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
