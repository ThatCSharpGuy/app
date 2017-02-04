using System;
using ThatCSharpGuy.iOS.Controls;
using ThatCSharpGuy.UI.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AlwaysScrollView), typeof(AlwaysScrollViewRenderer))]
namespace ThatCSharpGuy.iOS.Controls
{
	public class AlwaysScrollViewRenderer : ScrollViewRenderer
	{
		public static void Initialize()
		{
			var test = DateTime.UtcNow;
		}

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			this.AlwaysBounceVertical = true;
		}
	}
}

