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
    public class EditDetailsActivity : Activity {

        string SelectedTag = "";

        ImageView imgPreview;

        EditText txtDescription;

        CheckBox boxC2C;
        CheckBox boxAgility;
        CheckBox boxHack;
        CheckBox boxVto;
        CheckBox boxEvent; 

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EditDetailsActivity);

            imgPreview = FindViewById<ImageView>(Resource.Id.imgPreview);

            txtDescription = FindViewById<EditText>(Resource.Id.txtDescription);

            boxC2C = FindViewById<CheckBox>(Resource.Id.boxC2C);
            boxAgility = FindViewById<CheckBox>(Resource.Id.boxAgility);
            boxHack = FindViewById<CheckBox>(Resource.Id.boxHack);
            boxVto = FindViewById<CheckBox>(Resource.Id.boxVto);
            boxEvent = FindViewById<CheckBox>(Resource.Id.boxEvent);

            var btnSave = FindViewById<Android.Widget.Button>(Resource.Id.btnSave);


            Bitmap b = BitmapFactory.DecodeByteArray(App.Instance.CurrentPicture.Photo, 0, App.Instance.CurrentPicture.Photo.Length);

            imgPreview.SetImageBitmap(b);


            boxC2C.CheckedChange += boxC2C_CheckedChange;

            btnSave.Click += btnSave_Click;           
            
        }

        void btnSave_Click(object sender, EventArgs e) {
            App.Instance.CurrentPicture.Tag = SelectedTag;
            App.Instance.CurrentPicture.Description = txtDescription.Text;
            App.Instance.Pictures.Add(App.Instance.CurrentPicture);

            Toast.MakeText(this, SelectedTag, ToastLength.Short);

            Finish();
        }

        void boxC2C_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e) {

            if ((CheckBox)sender == boxC2C) {
                SelectedTag = "Crew2Crew";
            }

                        if ((CheckBox)sender == boxAgility) {
                SelectedTag = "SprintStars";
            }

                        if ((CheckBox)sender == boxHack) {
                SelectedTag = "Hackathon";
            }

                        if ((CheckBox)sender == boxVto) {
                SelectedTag = "VTO";
            }

                        if ((CheckBox)sender == boxEvent) {
                            SelectedTag = "Event";
            }
        }
    }
}