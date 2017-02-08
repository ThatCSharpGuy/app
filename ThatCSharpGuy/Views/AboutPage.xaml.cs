using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ThatCSharpGuy.UI.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            MainScroll.ParallaxView = HeaderView;
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var buttonClicked = sender as Button;
			string url;
			if (buttonClicked == MailButton)
			{
				url = "mailto:feregrino@thatcsharpguy.com";
			}
			else if (buttonClicked == FacebookButton)
			{
				url = "https://www.facebook.com/thatcsharpguy/";
			}
			else if (buttonClicked == TwitterButton)
			{
				url = "https://twitter.com/io_exception";
			}
			else if (buttonClicked == GitHubButton)
			{
				url = "https://github.com/ThatCSharpGuy";
			}
			else 
			{
				throw new InvalidOperationException();
			}
			Device.OpenUri(new Uri(url));
		}
    }
}
