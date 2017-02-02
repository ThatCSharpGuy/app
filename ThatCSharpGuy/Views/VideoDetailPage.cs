sing System;

using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
	public class VideoDetailPage : ContentPage
	{
		public VideoDetailPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

