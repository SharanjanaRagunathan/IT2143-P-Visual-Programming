using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Paper
{
    public class Art
    {

        private string name;
        private Artist artist;
        private int year;
        private double height;
        private double width;
        private string imagePath;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Artist Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }


        public Art(string _name, Artist _artist, int _year, double _height, double _width, double _price, string _imagePath)
        {
            this.name = _name;
            this.artist = _artist;
            this.year = _year;
            this.height = _height;
            this.width = _width;
            this.price = _price;
            this.imagePath = _imagePath;
        }


    }
}
