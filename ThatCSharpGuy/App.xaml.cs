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
			MainPage = new NavigationPage(new HomePage());
		}
	}
}
