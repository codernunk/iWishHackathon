using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyVanguardExperience {

    public class Picture {
        public int PictureID { get; set; }

        public string Author { get; set; }
        public string PhotoPath { get; set; }
        
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }

        public Picture(string author, string photo, string description, DateTime timeStamp) {
            Author = author;
            PhotoPath = photo;
            Description = description;
            TimeStamp = timeStamp;
        }
    }
}
