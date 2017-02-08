using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace ThatCSharpGuy.Droid
{
    [Activity(Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

			var formsApplication = new ThatCSharpGuy.UI.App();

			LoadApplication(formsApplication);
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            return base.OnPrepareOptionsMenu(menu);

            
        }

        public override void InvalidateOptionsMenu()
        {
            base.InvalidateOptionsMenu();
        }
    }
}

