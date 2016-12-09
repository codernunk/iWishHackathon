using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Timers;

namespace MyVanguardExperience.Droid {
    [Activity(Label = "My Vanguard Experience", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.splash", Icon = "@drawable/icon")]
    public class SplashScreen : Activity {
        protected override void OnCreate(Bundle bundle) {

            base.OnCreate(bundle);

            System.Timers.Timer timer = new Timer();
            timer.Interval = 3000; // 3 sec.
            timer.AutoReset = false; // Do not reset the timer after it's elapsed
            timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
                StartActivity(typeof(SplashScreenNext));
            };
            timer.Start();

        }
    }
}