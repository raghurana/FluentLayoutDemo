using Foundation;
using UIKit;

namespace FluentLayoutDemo
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        private UIWindow window;

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);
            window.RootViewController = new BlocksViewController();
            window.MakeKeyAndVisible();

            return true;  
        }
    }
}


