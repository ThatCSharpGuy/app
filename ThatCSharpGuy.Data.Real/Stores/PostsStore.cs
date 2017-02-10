using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ThatCSharpGuy.Data.Stores;
using ThatCSharpGuy.Models;
using Console = System.Diagnostics.Debug;

namespace ThatCSharpGuy.Data.Real
{
	public class PostsStore : IPostsStore
	{
		//private ITcsgApi _api;
		HttpClient _client;
	    public PostsStore()
	    {
			_client = new HttpClient(/*new LoggingHandler(new HttpClientHandler())*/)
			{
				BaseAddress = new Uri("https://raw.githubusercontent.com/ThatCSharpGuy/blog-api/master/")

			};

	    }



		public async Task<FullPost> GetPost(string id)
		{
			var qry = NormalizeId(id) + "post.json";
			var postsString = await _client.GetStringAsync(qry);
			var posts = Newtonsoft.Json.JsonConvert.DeserializeObject<FullPost>(postsString);
			return posts;
			
		}

		public async Task<PagedResponse<Post>> GetPosts(int page)
	    {
				var postsString = await _client.GetStringAsync("post" + page +".json");
			var posts =  Newtonsoft.Json.JsonConvert.DeserializeObject<PagedResponse<Post>>(postsString);


	        return posts;
	    }

		private string NormalizeId(string id)
		{
			if (id.StartsWith("/"))
				id = id.Substring(1);
			if (!id.EndsWith("/"))
				id = id + "/";
			return id;
		}
	}

	class LoggingHandler : DelegatingHandler
	{
		public LoggingHandler(HttpMessageHandler innerHandler)
			: base(innerHandler)
		{
		}


		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			Console.WriteLine("Request:");
			Console.WriteLine(request.ToString());
			if (request.Content != null)
			{
				Console.WriteLine(await request.Content.ReadAsStringAsync());
			}
			Console.WriteLine("");

			HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

			Console.WriteLine("Response:");
			Console.WriteLine(response.ToString());
			if (response.Content != null)
			{
				Console.WriteLine(await response.Content.ReadAsStringAsync());
			}
			Console.WriteLine("");

			return response;
		}
	}
}

