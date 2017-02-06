using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
	public partial class PostPage : ContentPage
	{
		string _id;
		public PostPage(string id)
		{
			InitializeComponent();
			_id = id;
			ParallaxScroll.ParallaxView = HeaderView;
		}

		string _postName;
		string _postDate;

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			ParallaxScroll.Scrolled += MainScroll_Scrolled;
			ParallaxScroll.Parallax();

			var store = new Data.Real.PostsStore();
			var post = await store.GetPost(_id);
			Content.Html = post.content;
			//Content.Text = post.content;
			PostAuthor.Text = post.author;
			PostTitle.Text = post.Title;
			//System.Diagnostics.Debug.WriteLine($"{Content.Text.Length} - {post.content.Length}");
			_postDate = post.Date.ToString();
			Title = _postDate;

			var image = "https://res.cloudinary.com/appod/image/fetch/t_TCSG%20app/" + post.FeaturedImage;
			FeaturedImage.Source = image;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			ParallaxScroll.Scrolled -= MainScroll_Scrolled;
		}


        void MainScroll_Scrolled (object sender, ScrolledEventArgs e)
		{
			if (e.ScrollY > (MainStack.Height - PostTitle.Height))
				Title = PostTitle.Text;
			else
				Title = _postDate;;
		}
	}


}
