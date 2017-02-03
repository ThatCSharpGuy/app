using System;
using System.Threading.Tasks;
using ThatCSharpGuy.Data.Stores;
using ThatCSharpGuy.Models;

namespace ThatCSharpGuy.Data.Real
{
	public class PostsStore : IPostsStore
	{
	    private ITcsgApi _api;
	    public PostsStore()
	    {
	        _api = Refit.RestService.For<ITcsgApi>("https://github.com/ThatCSharpGuy/blog-api");
	    }
	    public async Task<PagedResponse<Post>> GetPosts(int page)
	    {
	        var posts = await _api.GetPosts(page);
	        return posts;
	    }
	}
}

