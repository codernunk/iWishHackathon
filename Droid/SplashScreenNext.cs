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
    [Activity(Label = "splashScreenNext", MainLauncher = false, NoHistory = true, Theme = "@style/Theme.splashNext", Icon = "@drawable/icon")]
    public class SplashScreenNext : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 3000; // 3 sec.
            timer.AutoReset = false; // Do not reset the timer after it's elapsed
            timer.Elapsed += (object sender, ElapsedEventArgs e) => {
                StartActivity(typeof(MainActivity));
            };
            timer.Start();

        }
    }
}