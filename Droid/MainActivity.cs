using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.IO;
using Android.Provider;


namespace MyVanguardExperience.Droid
{

	[Activity(Label = "MyVanguardExperience.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
        static readonly File file = new File(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), "tmp.jpg");

        protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());

            (Xamarin.Forms.Application.Current as App).ShouldTakePicture += () => {
                var intent = new Intent(MediaStore.ActionImageCapture);
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(file));
                StartActivityForResult(intent, 0);
            };
		}

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            (Xamarin.Forms.Application.Current as App).ShowImage(file.Path);
        }
    }
}
