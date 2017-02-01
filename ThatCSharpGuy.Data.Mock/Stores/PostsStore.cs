using System.Linq;
using System.Threading.Tasks;
using ThatCSharpGuy.Data.Stores;
using ThatCSharpGuy.Models;

namespace ThatCSharpGuy.Data.Mock.Stores
{
    public class PostsStore : IPostsStore
    {
        private MockingData _data;
        public PostsStore()
        {
            _data = MockingData.GetInstance();
        }

        public async Task<PagedResponse<Post>> GetPosts(int page)
        {
            var returnResponse = new PagedResponse<Post>()
            {
                Items = _data.Posts.Skip(page * Constants.PageSize).Take(Constants.PageSize).ToList(),
                CurrentPage = page,
                TotalPages = _data.Posts.Count / Constants.PageSize
            };

            return await Task.FromResult<PagedResponse<Post>>(returnResponse);
        }
    }
}
