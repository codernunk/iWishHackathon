using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyVanguardExperience {

    public class Picture {
        int PictureID { get; set; }

        string Author { get; set; }
        Image Photo { get; set; }
        string Description { get; set; }
        DateTime TimeStamp { get; set; }

        public Picture(string author, Image photo, string description, DateTime timeStamp) {
            Author = author;
            Photo = photo;
            Description = description;
            TimeStamp = timeStamp;
        }
    }
}
