using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.IO;

namespace MyVanguardExperience.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());
            var imagePicker = new UIImagePickerController { SourceType = UIImagePickerControllerSourceType.Camera };

            (Xamarin.Forms.Application.Current as App).ShouldTakePicture += () =>
            app.KeyWindow.RootViewController.PresentViewController(
            imagePicker, true, null);

            imagePicker.FinishedPickingMedia += (sender, e) => {
                var filepath = Path.Combine(Environment.GetFolderPath(
                                   Environment.SpecialFolder.MyDocuments), "tmp.jpg");
                var image = (UIImage)e.Info.ObjectForKey(new NSString("UIImagePickerControllerOriginalImage"));
                InvokeOnMainThread(() => {
                    image.AsPNG().Save(filepath, false);
                    (Xamarin.Forms.Application.Current as App).ShowImage(filepath);
                });
                app.KeyWindow.RootViewController.DismissViewController(true, null);
            };

            imagePicker.Canceled += (sender, e) => app.KeyWindow.RootViewController.DismissViewController(true, null);

            return base.FinishedLaunching(app, options);
		}
	}
}
