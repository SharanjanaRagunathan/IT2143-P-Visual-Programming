using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024Paper
{
    public partial class ViewArt : Form
    {

        Artist[] artists = new Artist[20];
        Art[] arts = new Art[20];

        public ViewArt(Artist[] _artists,Art[] _arts)
        {

            this.artists = _artists;
            this.arts = _arts;

            InitializeComponent();
            loadArts();
        }

        public void loadArts()
        {
            if(arts != null)
            {
                foreach (var art in arts)
                {

                    if (art != null)
                    {
                        cbArtName.Items.Add(art.Name);
                    }

                } }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }

        private void ViewArt_Load(object sender, EventArgs e)
        {

        }

        private void cbArtName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Art art in arts)
            {

                if (art != null)
                {
                    if (art.Name == (cbArtName.SelectedItem.ToString()))
                    {
                        txtHeight.Text = art.Height.ToString();
                        txtWidth.Text = art.Width.ToString();
                        txtYear.Text = art.Year.ToString();
                        txtPrice.Text = art.Price.ToString();

                        pbImageArt.Image = Image.FromFile(art.ImagePath);


                        foreach (Artist artist in artists)
                        {
                            if (artist != null)
                            {
                                if (art != null && art.Name.Equals(cbArtName.Text))
                                {
                                    txtNameArtist.Text = artist.Name;
                                    txtSex.Text = artist.Gender;
                                    txtStyle.Text = artist.Style;

                                    string dob = artist.DOB.ToString();

                                    string dobYear = dob.Substring(dob.Length-4, 4);

                                    int currentYear = DateTime.Now.Year;
                                    int age = currentYear - Convert.ToInt32(dobYear);


                                    //int age = DateTime.Now.Year - ;

                                    txtAge.Text = age.ToString();

                                    pbAritist.Image = Image.FromFile(artist.ImagePath);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(artists, arts);
            this.Hide();
            dashboard.Show();
        }
    }
}
