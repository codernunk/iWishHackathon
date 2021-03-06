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

namespace MyVanguardExperience.Droid {
    [Activity(Label = "My Vanguard Experience", Icon = "@drawable/icon")]
    public class BrowseActivity : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.myExperience);

            var gridview = FindViewById<GridView>(Resource.Id.experienceGridView);
            gridview.Adapter = new ImageAdapter(this);

            gridview.ItemClick += (sender, args) => {

                App.Instance.CurrentPicture = App.Instance.Pictures[args.Position];
                //Toast.MakeText(this, App.Instance.Pictures[args.Position].Description, ToastLength.Short).Show()
                StartActivityForResult(typeof(ShareExperienceActivity), 10);
            };
        

            //// Create your application here
            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            ////this.SetContentView(ContentPage {
            ////    Content = new Label {
            ////        Text = "Hello, Forms!",
            ////        VerticalOptions = LayoutOptions.CenterAndExpand,
            ////        HorizontalOptions = LayoutOptions.CenterAndExpand,
            ////    }
            ////}; 

            //List<Xamarin.Forms.View> buttons = new List<Xamarin.Forms.View>();

            //foreach (Picture p in App.Instance.Pictures) {
            //    //var beachImage = new Image { Aspect = Aspect.AspectFit };
            //    //beachImage.Source = p.Photo;

            //    Xamarin.Forms.Button b = new Xamarin.Forms.Button {
            //        Text = p.Description,
            //        Image = p.PhotoPath,
            //        Command = null,
            //    };

            //    buttons.Add(b);
            //}


            //ContentPage content = new ContentPage {
            //    Content = new StackLayout {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //        }
            //    }

            //};

            
            ////DisplayAlert("Alert", "You have been alerted", "OK");
            //this.SetPage(content);
            
            
        }
    }
}