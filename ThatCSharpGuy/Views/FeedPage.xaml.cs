using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThatCSharpGuy.Data.Stores;
using Xamarin.Forms;

namespace ThatCSharpGuy.UI.Views
{
    public partial class FeedPage : ContentPage
    {
        public FeedPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            IPostsStore store = new PostsStore();

            PostList.ItemsSource = (await store.GetPosts(0)).Items;
        }
    }
}
