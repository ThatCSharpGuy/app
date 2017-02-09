using System;
using System.Collections.Generic;

namespace ThatCSharpGuy.Models
{
	using ModelsPreserve;
	[Preserve]
	public class FullPost : Post
	{
		[Preserve]
		public FullPost()
		{

		}
		public IList<string> tags { get; set; }
		public string content { get; set; }
		public string github { get; set; }
		public string youtube { get; set; }
	}
}

