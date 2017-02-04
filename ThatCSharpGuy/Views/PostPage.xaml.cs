using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThatCSharpGuy.UI
{
	public partial class PostPage : ContentPage
	{
		public PostPage()
		{
			InitializeComponent();
			ParallaxScroll.ParallaxView = HeaderView;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			Body.Text = PostText;
			//PostContent.Markdown = PostText;
		}

		const string PostText = @"##Lorem ipsum dolor sit amet  
Consectetur adipiscing elit. Nulla tristique iaculis leo, ultricies volutpat nulla suscipit ut. In condimentum purus id risus condimentum, id consectetur quam malesuada. In in lobortis nibh, id malesuada magna. Mauris faucibus velit sed purus pretium, in egestas elit tempor. Nunc interdum congue laoreet. Aenean volutpat, dolor eu laoreet rutrum, metus orci bibendum nisl, at luctus lacus urna non ante. Duis sed cursus purus, et consequat dui. Nulla feugiat erat metus, id mollis dolor feugiat et. Suspendisse luctus imperdiet arcu, in sodales elit euismod in. Ut finibus lacinia turpis. Donec a nisi et est auctor molestie id vitae tortor.

Aliquam risus augue, malesuada eu neque sit amet, posuere ultricies erat. Fusce non est blandit, porttitor dui vel, venenatis leo. Etiam tincidunt urna erat, sit amet mattis urna cursus a. Cras et scelerisque augue. Mauris elit est, blandit vitae orci quis, sollicitudin pulvinar ligula. Nunc ultricies lobortis dapibus. Duis orci lacus, posuere ut augue ut, imperdiet molestie ante.

Aliquam in pulvinar ante. Cras quis nunc risus. Sed arcu mi, condimentum tempor nisi a, blandit dictum velit. Sed in risus lacus. In sit amet varius augue. Aenean a urna vitae massa accumsan volutpat sed ac tortor. Vivamus egestas, enim ut placerat efficitur, ipsum risus scelerisque magna, ut tincidunt nunc ex et tellus. Nullam ultricies, metus id viverra luctus, neque sem facilisis felis, non commodo arcu nunc in lacus. Aliquam erat volutpat.

Nunc rutrum, libero eu dictum pellentesque, velit magna posuere massa, nec lobortis velit enim non nisl. Integer sagittis rutrum velit, et varius arcu mollis id. Etiam ullamcorper lectus eleifend lectus pharetra, a euismod lorem malesuada. Vestibulum et ante fermentum, malesuada sapien ac, hendrerit erat. Sed nec sapien faucibus, tempus velit eget, tristique est. Nunc porttitor est eu ex commodo, vel dapibus lectus ullamcorper. In sit amet urna ac risus accumsan feugiat. Vestibulum a convallis nisi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Ut eu vestibulum elit, a aliquet diam. Nullam elementum enim nec purus eleifend tincidunt.

Sed convallis blandit ex at lacinia. Etiam fringilla nulla justo. Suspendisse turpis lacus, ornare quis lectus vitae, lobortis finibus nunc. Proin sodales, mauris in consectetur ullamcorper, nulla ante posuere turpis, quis posuere enim risus id leo. Duis ut enim tristique, rhoncus augue ut, vehicula augue. Etiam luctus purus sodales maximus consequat. Donec et sollicitudin justo. Nullam ac metus et tortor aliquam auctor ut ac nisl. Integer fermentum purus vitae augue dapibus molestie. Sed a magna vitae nisi pretium congue.";
	}


}
