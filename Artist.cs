using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2024Paper
{
    public class Artist
    {
        private string name;
        private string dob;
        private string sex;
        private string style;
        private string imagePath;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Gender
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public Artist(string name, string dob, string sex, string style, string imagePath)
        {
            this.name = name;
            this.dob = dob;     
            this.sex = sex;
            this.style = style;
            this.imagePath = imagePath;
        }







    }
}
