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
	    private ITcsgApi _api;
	    public PostsStore()
	    {
			var client = new HttpClient(/*new LoggingHandler(new HttpClientHandler())*/)
			{
				BaseAddress = new Uri("https://raw.githubusercontent.com/ThatCSharpGuy/blog-api/master/")

			};

	        _api = Refit.RestService.For<ITcsgApi>(client);
	    }



		public async Task<FullPost> GetPost(string id)
		{
			var posts = await _api.GetPost(NormalizeId(id));
			return posts;
			
		}

		public async Task<PagedResponse<Post>> GetPosts(int page)
	    {
	        var posts = await _api.GetPosts(page);
	        return posts;
	    }

		private string NormalizeId(string id)
		{
			if (!id.StartsWith("/"))
				id = "/" + id;
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

