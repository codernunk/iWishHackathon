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
using Android.Graphics;
using System.IO;


namespace MyVanguardExperience.Droid
{

	[Activity(Label = "mainActivity", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
        static readonly Java.IO.File file = new Java.IO.File(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), "tmp.jpg");

        protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.myExperience);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());

            (Xamarin.Forms.Application.Current as App).ShouldTakePicture += () => {
                var intent = new Intent(MediaStore.ActionImageCapture);
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(file));
                StartActivityForResult(intent, 0);
            };

            (Xamarin.Forms.Application.Current as App).GotoBrowseActivity += () => {
                StartActivity(typeof(BrowseActivity));
            };

            (Xamarin.Forms.Application.Current as App).SendEmail += () => {

                if (App.Instance.Pictures.Count == 0) {
                    return;
                }

                StartActivityForResult(typeof(ShareExperienceActivity), 10);

                //// var pdfPath = FileSystemUtils.CopyFileToPersonalFolder (media.FilePathUri ().AbsolutePath);
                //var pdfPath = App.Instance.Pictures[0].PhotoPath;
                //var email = new Intent(Android.Content.Intent.ActionSend);
                //var file = new Java.IO.File(pdfPath);
                //var uri = Android.Net.Uri.FromFile(file);

                //file.SetReadable(true, false);
                //email.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { "jnunk.cuber@gmail.com" });
                //email.PutExtra(Android.Content.Intent.ExtraSubject, "MyVanguardExperience");
                //email.PutExtra(Intent.ExtraStream, uri);
                //email.SetType("message/rfc822");
                //StartActivity(Intent.CreateChooser(email, "Send mail..."));
            };
		}

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == 10) {
                return;
            }

            if (requestCode != 456) {

                Bitmap b = BitmapFactory.DecodeFile(file.Path);

                byte[] bitmapData;
                using (var stream = new MemoryStream()) {
                    b.Compress(Bitmap.CompressFormat.Jpeg, 0, stream);
                    bitmapData = stream.ToArray();
                }

                App.Instance.CurrentPicture = new Picture("u1bh", file.Path, bitmapData, DateTime.Now);

                StartActivityForResult(typeof(EditDetailsActivity), 456);
            }

        }
    }
}
