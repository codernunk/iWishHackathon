using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyVanguardExperience
{
	public partial class App : Application
	{
        public static App Instance;
        readonly Image image = new Image();

        public App() {
            Instance = this;

            var btnMoment = new Button {
                Text = "Capture a Moment",
                Command = new Command(o => ShouldTakePicture()),
            };

            var btnExport = new Button {
                Text = "Share the Experience",
                Command = new Command(o => SendEmail()),
            };

            var btnBrowsMoments = new Button {
              Text = "My Experiences",
                Command = new Command(o => GotoBrowseActivity()),
            };
            
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        btnMoment,
                        btnExport,
                        btnBrowsMoments,
                        image,
                    },
                },
            };
        }

        public event Action ShouldTakePicture = () => { };
        public event Action GotoBrowseActivity = () => { };
        public event Action SendEmail = () => { }; 

        public List<Picture> Pictures = new List<Picture>();

        public Picture CurrentPicture;

        public void ShowImage(string filepath) {
            //image.Source = ImageSource.FromFile(filepath);
            
            //Picture pic = new Picture("u1bh", filepath, "Test Photo", DateTime.Now);
        }

        protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
