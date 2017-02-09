using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            _store = new PostsStore();
            _posts = new ObservableCollection<Post>();
            PostList.ItemsSource = _posts;
            PostList.ItemSelected += async (sender, e) =>
            {
                var selectedPost = PostList.SelectedItem as Post;
                if (selectedPost != null)
                {
                    await Navigation.PushAsync(new PostPage(selectedPost.id));
                    PostList.SelectedItem = null;
                }
            };

            PostList.ItemAppearing += async (sender, e) =>
            {
                if (_posts.Last().Equals(e.Item))
                {
                    await LoadData();
                }
            };
        }

        private ObservableCollection<Post> _posts;
        private int _page = 1;
        private PostsStore _store;

        async Task LoadData()
        {
            var a = new Label();
            
            if (_page < 0) return;
            var response = await _store.GetPosts(_page);
            foreach (var post in response.items)
            {
                _posts.Add(post);
            }
            if (response.current_page == response.total_pages)
                _page = -1;
            else
            {
                _page++;
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadData();

        }
    }
}
