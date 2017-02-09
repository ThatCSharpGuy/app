using System;
using System.Collections.Generic;
using ThatCSharpGuy.Models;
using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
	public partial class PostPage : ContentPage
	{
		const string SiteBaseUrl = "http://thatcsharpguy.com";

		string _id;

		ToolbarItem _gitHubButton;
		ToolbarItem _youTubeButton;

		public PostPage(string id)
		{
			InitializeComponent();
			_gitHubButton = new ToolbarItem { Icon = "github" };
			_gitHubButton.Clicked += Button_Clicked;
			_youTubeButton = new ToolbarItem { Icon = "video" };
			_youTubeButton.Clicked += Button_Clicked;

			_id = id;
		}

		bool _initialLoad = true;
		bool _initialVideoLoad = false;

		String _page;
		FullPost _post;

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var store = new Data.Real.PostsStore();
			_post = await store.GetPost(_id);

			if (!string.IsNullOrEmpty(_post.github))
				ToolbarItems.Add(_gitHubButton);
			if (!string.IsNullOrEmpty(_post.youtube))
				ToolbarItems.Add(_youTubeButton);

			Title = $"{_post.Date.ToLocalTime():dd/MM/yyyy}";
			PostTitle.Text = _post.Title;
			_page = "http://thatcsharpguy.com" + _id + "/m.html";


			Site.Source = _page;
			Site.Navigating += ContentNavigating;

		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			Site.Navigating -= ContentNavigating;
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			var senderButton = sender as ToolbarItem;
			if (senderButton == _gitHubButton)
			{
				Device.OpenUri(new Uri(_post.github));
			}
			else if (senderButton == _youTubeButton)
			{
				Device.OpenUri(new Uri("https://youtube.com/watch?v=" + _post.youtube));
			}
		}

		async void ContentNavigating(object sender, WebNavigatingEventArgs e)
		{
			e.Cancel = !e.Url.Equals(_page);
			//if (e.Url.StartsWith(SiteBaseUrl))
			//{
			//	string iid = e.Url.Substring(SiteBaseUrl.Length);
			//	e.Cancel = true;
			//	await Navigation.PushAsync(new PostPage(iid));
			//}
			//else
			//{

			//	try
			//	{
			//		var uri = new Uri(e.Url);
			//		Device.OpenUri(uri);
			//	}
			//	catch (Exception)
			//	{
			//	}
			//}
			// All navigation is CANCELLED
		}	
	}
}
