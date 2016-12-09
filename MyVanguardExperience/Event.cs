using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyVanguardExperience {

    public class Picture {

        public string Author { get; set; }
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
        public string Tag { get; set; }
        
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }

        public Xamarin.Forms.Image Image { get; set; }


        public Picture(string author, string photoPath, byte[] photo, DateTime timeStamp) {
            Author = author;
            PhotoPath = photoPath;
            Photo = photo;
            TimeStamp = timeStamp;

        }
    }
}
