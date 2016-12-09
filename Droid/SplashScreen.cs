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
    [Activity(Label = "My Vanguard Experience", MainLauncher=true,NoHistory=true,Theme="@style/Theme.splash",Icon="@drawable/icon")]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            Thread.Sleep(2000);
            StartActivity(typeof(SplashScreenNext));
        }
    }
}