using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace MyVanguardExperience.Droid {
    public class ImageAdapter : BaseAdapter {
        private readonly Context context;

        public ImageAdapter(Context c) {
            context = c;
        }

        public override int Count {
            get { return App.Instance.Pictures.Count; }
        }

        public override Object GetItem(int position) {
            return null;
        }

        public override long GetItemId(int position) {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent) {
            ImageView imageView;

            if (convertView == null) {
                // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.LayoutParameters = new AbsListView.LayoutParams(85, 85);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(8, 8, 8, 8);
            } else {
                imageView = (ImageView)convertView;
            }

            // imageView.SetImageResource(thumbIds[position]);
            imageView.SetImageURI(Android.Net.Uri.FromFile(new Java.IO.File(App.Instance.Pictures[position].PhotoPath)));
            return imageView;
        }
    }

}