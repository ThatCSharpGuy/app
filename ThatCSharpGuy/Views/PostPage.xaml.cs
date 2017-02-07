using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
	public partial class PostPage : ContentPage
	{
		const string SiteBaseUrl = "http://thatcsharpguy.com";

		string _id;
		public PostPage(string id)
		{
			InitializeComponent();
			System.Diagnostics.Debug.WriteLine("New page " + Site.Source);
			Site.Navigated += (sender, e) => { 
			};
			_id = id;
		}

		bool _initialLoad = true;
		bool _initialVideoLoad = false;

		String _page;

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var store = new Data.Real.PostsStore();
			var post = await store.GetPost(_id);
			Title = $"{post.Date.ToLocalTime():dd/MM/yyyy}";
			PostTitle.Text = post.Title;
			_page = "http://thatcsharpguy.com" + _id + "/m.html";
			Site.Source = _page;
			Site.Navigating += ContentNavigating;

		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			Site.Navigating -= ContentNavigating;
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
