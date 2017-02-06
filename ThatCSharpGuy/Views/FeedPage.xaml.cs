using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThatCSharpGuy.Data.Real;
using ThatCSharpGuy.Data.Stores;
using ThatCSharpGuy.Models;
using Xamarin.Forms;

namespace ThatCSharpGuy.UI.Views
{
    public partial class FeedPage : ContentPage
    {
        public FeedPage()
        {
            InitializeComponent();

			PostList.ItemSelected += async (sender, e) =>
			{
				var selectedPost = PostList.SelectedItem as Post;
				if (selectedPost != null)
				{
					await Navigation.PushAsync(new PostPage(selectedPost.id));
					PostList.SelectedItem = null;
				}
			};
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            IPostsStore store = new PostsStore();
			var respns4 = await store.GetPosts(2);
			PostList.ItemsSource = respns4.Items;

        }
    }
}
