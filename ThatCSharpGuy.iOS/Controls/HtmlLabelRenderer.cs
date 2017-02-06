using System;
using CoreGraphics;
using Foundation;
using ThatCSharpGuy.iOS.Controls;
using ThatCSharpGuy.UI.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelRenderer))]
namespace ThatCSharpGuy.iOS.Controls
{
	public class HtmlLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			UpdateText();
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName.Equals(nameof(HtmlLabel.Html)) || e.PropertyName.Equals(nameof(HtmlLabel.Text)))
			{
				UpdateText();
			}
			else
			{
				base.OnElementPropertyChanged(sender, e);
			}
		}
		int h = 0;
		void UpdateText()
		{
			Control.Lines = 0;
			Control.LineBreakMode = UILineBreakMode.WordWrap;
			var aa = Element as HtmlLabel;

			var attr = new NSAttributedStringDocumentAttributes();
			var nsError = new NSError();
			attr.DocumentType = NSDocumentType.HTML;

			var myHtmlData = NSData.FromString(aa.Html ?? $"<b>Hola</b> {h++}", NSStringEncoding.Unicode);
			var attrd = new NSAttributedString(myHtmlData, attr, ref nsError);

			Control.AttributedText = attrd;// $"Hola {h++} {attrd}";

			var label = Control;

			var rect = label.AttributedText?.GetBoundingRect(new CGSize(320, 1000),
																NSStringDrawingOptions.UsesLineFragmentOrigin, 
			                                                 null);
			var frame = label.Frame;
			var newSize = new CGSize(100,100);
			frame.Size = newSize;
			label.Frame = frame;

			return;

			//var htmlElement = Element as HtmlLabel;
			//if (String.IsNullOrEmpty(htmlElement?.Html))	 return;


			//var attr = new NSAttributedStringDocumentAttributes();
			//var nsError = new NSError();
			//attr.DocumentType = NSDocumentType.HTML;

			//var myHtmlData = NSData.FromString(htmlElement.Html, NSStringEncoding.Unicode);
			//var attrd = new NSAttributedString(myHtmlData, attr, ref nsError);
			////var tv = new UITextView { AttributedText = attrd }.AttributedText;
			//Device.BeginInvokeOnMainThread(() =>
			//{
			//	this.Control.AttributedText = attrd;
			//	this.Control.Text = htmlElement.Html;
			//});
			//if (nsError != null)
			//{
			//	;
			//}
		}
	}
}
