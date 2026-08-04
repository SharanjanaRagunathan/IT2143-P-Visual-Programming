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
    public partial class AddArt : Form
    {

        int artCount = 0;

        Artist[] artists = new Artist[20];
        int artistCount;
       
        public AddArt(Artist[] _artists)
        {
            this.artists = _artists;
            

            InitializeComponent();
            loadArtists();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadArtists()
        {
            foreach (Artist artist in artists)
            {

                if (artist != null) // Check for null before accessing properties
                {
                    cbArtists.Items.Add(artist.Name);
                }
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                {
                    e.Handled = true;
                }
            }
        }

        string imagePath;
    


        private void btnLoadImage_Click(object sender, EventArgs e)
        {

           OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select a picture";
            ofd.Filter = "Select Image| *.png; *.jpg; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK) { 
                imagePath = ofd.FileName;
                pbImage.Image = Image.FromFile(imagePath);
            }

        }
        Art[] arts = new Art[20];

        private void btnMain_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(artists,arts);
            this.Hide();
            dashboard.Show();
        }

        private void AddArt_Load(object sender, EventArgs e)
        {
           
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string name = txtName.Text;

                if (cbArtists.SelectedItem == null)
                {
                    MessageBox.Show("Please select an artist from the dropdown.");
                    return;
                }

                string artistName = cbArtists.SelectedItem.ToString();

                Artist artist = null;



                foreach (Artist artist1 in artists)
                {

                    if (artist1 != null)
                    {
                        if (artist1.Name == name)
                        {
                            artist = artist1;
                        }
                    }

                }

                if (string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(artistName) || string.IsNullOrEmpty(numHeight.Value.ToString()) || string.IsNullOrEmpty(numWidth.Value.ToString()) || string.IsNullOrEmpty(txtYear.Text.ToString()) || pbImage.Image == null)
                {
                    MessageBox.Show("Plaese provide every details and a picture too");
                    return;
                }

                int year = Convert.ToInt16(txtYear.Text);
                double height = Convert.ToDouble(numHeight.Value);
                double width = Convert.ToDouble(numWidth.Value); ;
                string pathToImage = imagePath;
                double price = Convert.ToDouble(textBox1.Text);



                Art art = new Art(name, artist, year, height, width, price, pathToImage);

                arts[artCount] = art;
                

                txtName.ResetText();
                txtYear.ResetText();
                textBox1.ResetText();
                cbArtists.ResetText();

                pbImage.Image = null;

                artCount++;
            }
            catch(Exception x)
            {
                MessageBox.Show("Error occured");
            }
            


        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                {
                    e.Handled = true;
                }
            }
        }
    }
}
