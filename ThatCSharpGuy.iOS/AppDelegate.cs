using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading.Forms.Touch;
using Foundation;
using Messier16.Forms.Controls.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace App.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
			CachedImageRenderer.Init();
			PlatformTabbedPageRenderer.Init();

			var formsApp = new ThatCSharpGuy.UI.App();

			UINavigationBar.Appearance.TintColor = ((Color)formsApp.Resources["AccentColor"] ).ToUIColor();
			UINavigationBar.Appearance.BackgroundColor = UIColor.Red; // ((Color)formsApp.Resources["BackgroundAltColor"]).ToUIColor();

            LoadApplication(formsApp);
            return base.FinishedLaunching(app, options);
        }
    }
}
