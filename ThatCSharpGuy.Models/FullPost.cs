using System;
using System.Collections.Generic;

namespace ThatCSharpGuy.Models
{
	public class FullPost : Post
	{
		public IList<string> tags { get; set; }
		public string content { get; set; }
		public string github { get; set; }
		public string youtube { get; set; }
	}
}

