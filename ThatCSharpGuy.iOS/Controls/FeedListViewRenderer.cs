using System;
using ThatCSharpGuy.iOS.Controls;
using ThatCSharpGuy.UI.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FeedListView), typeof(FeedListViewRenderer))]
namespace ThatCSharpGuy.iOS.Controls
{
	public class FeedListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
			//Control.EstimatedRowHeight = 250;
		}
	}
}

