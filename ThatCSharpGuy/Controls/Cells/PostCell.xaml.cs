using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThatCSharpGuy.Models;

using Xamarin.Forms;

namespace ThatCSharpGuy.UI.Controls.Cells
{
    public partial class PostCell : ViewCell
    {
        


        public PostCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = BindingContext as Post;
            if (item == null)
                return;

            Image.Source = "https://res.cloudinary.com/appod/image/fetch/t_TCSG%20app/" +item.FeaturedImage;
            Label.Text = item.Title;
        }
    }
}
