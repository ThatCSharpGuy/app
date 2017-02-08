using System;
using System.Collections.Generic;
using ThatCSharpGuy.UI.Views;
using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
	public partial class App :Application
	{
		public App()
		{
			InitializeComponent();
			var mainPage = new NavigationPage(new HomePage());
			mainPage.BarBackgroundColor = (Color)Resources["BackgroundAltColor"];
			MainPage = mainPage;
		}
	}
}
