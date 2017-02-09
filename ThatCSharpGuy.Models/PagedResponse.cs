using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace ModelsPreserve
{
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Delegate, AllowMultiple = true)]
	public sealed class PreserveAttribute : Attribute
	{
	}
}

namespace ThatCSharpGuy.Models
{
	using ModelsPreserve;

	[Preserve]
    public class PagedResponse<T>
    {
		[Preserve]
		public PagedResponse()
		{

		}

		[JsonProperty("items")]
        public List<T> items { get; set; }
        [JsonProperty("current_page")]
        public int current_page { get; set; }
        [JsonProperty("total_pages")]
        public int total_pages { get; set; }
    }
}
