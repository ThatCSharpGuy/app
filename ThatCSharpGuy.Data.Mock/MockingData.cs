using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThatCSharpGuy.Models;

namespace ThatCSharpGuy.Data.Mock
{
    class MockingData
    {

        public List<Post> Posts { get; private set; }

        private MockingData()
        {
            var posts = Enumerable.Range(0, 70)
                .Select(i => new Post
                {
                    Title = $"Post {i} de bla bla bla",
                    Date = DateTimeOffset.Now,
                    Summary = "Bla bla bla bvla bvlaalkjdfioj lalks dfjdw do0 dwodw dwjdw dwoidwm dwod"
                });
            Posts = new List<Post>(posts);
        }

        private static MockingData _instance;

        public static MockingData GetInstance()
        {
            return _instance ?? (_instance = new MockingData());
        }
    }
}
