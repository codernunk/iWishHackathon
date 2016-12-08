using System;
using Xamarin.Forms;

namespace MyVanguardExperience
{
	public partial class App : Application
	{
        public static App Instance;
        readonly Image image = new Image();

        public App()
		{
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                new Button {
                    Text = "Capture Moment",
                    Command = new Command(o => ShouldTakePicture()),
                },
                image,
            },
                },
            };
            //MainPage = new MyVanguardExperiencePage();
        }

        public event Action ShouldTakePicture = () => {};

        public void ShowImage(string fileLocation)
        {
            image.Source = ImageSource.FromFile(fileLocation);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
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
