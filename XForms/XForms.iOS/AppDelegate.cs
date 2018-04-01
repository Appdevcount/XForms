
using Foundation;
using Lottie.Forms.iOS.Renderers;
using UIKit;

namespace XForms.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new App());

            //Lottie Animation Init
            AnimationViewRenderer.Init();

            return base.FinishedLaunching(app, options);
		}
	}
}
