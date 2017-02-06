using System.Collections.Generic;
using System.Threading.Tasks;
using ThatCSharpGuy.Models;

namespace ThatCSharpGuy.Data.Stores
{
    public interface IPostsStore
    {
        Task<PagedResponse<Post>> GetPosts(int page);

		Task<FullPost> GetPost(string id);
    }
}