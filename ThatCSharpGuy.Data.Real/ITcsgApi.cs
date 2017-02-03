using System.Threading.Tasks;
using Refit;
using ThatCSharpGuy.Models;

namespace ThatCSharpGuy.Data.Real
{
    internal interface ITcsgApi
    {
        [Get("/post{page}.json")]
        Task<PagedResponse<Post>> GetPosts(int page);
    }
}
