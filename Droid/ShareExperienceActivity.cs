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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using System.IO;

namespace MyVanguardExperience.Droid {
    [Activity(Label = "My Vanguard Experience", Icon = "@drawable/icon")]
    public class ShareExperienceActivity : Activity {



        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.shareMyExperience);


            Android.Widget.Button btnSave = FindViewById<Android.Widget.Button>(Resource.Id.btnSave);

            btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e) {
            Finish();
        }
    }
}