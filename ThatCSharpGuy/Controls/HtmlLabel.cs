using System;
using Xamarin.Forms;

namespace ThatCSharpGuy.UI.Controls
{
	public class HtmlLabel : Label
	{

        public static readonly BindableProperty HtmlProperty =
			BindableProperty.Create(nameof(Html), typeof(string), typeof(HtmlLabel), null);

		public string Html
		{
			get { return (string)GetValue(HtmlProperty); }
			set { SetValue(HtmlProperty, value); }
		}
	}
}
