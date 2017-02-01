using System;
using System.Collections.Generic;
using System.Text;

namespace ThatCSharpGuy.Models
{
    public class PagedResponse<T>
    {
        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
