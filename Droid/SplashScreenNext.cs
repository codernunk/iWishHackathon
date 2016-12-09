using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyVanguardExperience.Droid
{
    [Activity(Label = "splashScreenNext", MainLauncher = false, NoHistory = true, Theme = "@style/Theme.splashNext", Icon = "@drawable/icon")]
    public class SplashScreenNext : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            Thread.Sleep(2000);
            StartActivity(typeof(MainActivity));
        }
    }
}