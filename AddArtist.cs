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
    public partial class AddArtist : Form
    {
        int artistCount = 0;
       
        public AddArtist()
        {
           
            InitializeComponent();
        }


        public string pathToImage  = "";

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Slect an image";
            openFileDialog.Filter = "Image Files | *.png; *.jpg; *.gif";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToImage = openFileDialog.FileName;
                pbImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(artists);
            this.Hide();
            dashboard.Show();
        }

        public Artist[] artists = new Artist[20];

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string dob = dtDob.Text;
                string style = cbStyle.Text;
                string sex;
                string imagePath = pathToImage;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a name");
                    return;
                }

                if (string.IsNullOrEmpty(dtDob.ToString()))
                {
                    MessageBox.Show("Please enter a Date of Birth");
                    return;
                }

                if (cbStyle.SelectedIndex == null)
                {
                    MessageBox.Show("Please select a style");
                    return;
                }

                if (rbFemale.Checked)
                {
                    sex = "Female";
                }
                else if (rbMale.Checked)
                {
                    sex = "male";
                }
                else
                {
                    MessageBox.Show("Please select a gender");
                    return;
                }

                if (pbImage.Image == null)
                {
                    MessageBox.Show("Please select a picture");
                    return;

                }




                Artist artist = new Artist(name, dob, sex, style, imagePath);
                artists[artistCount] = artist;
                artistCount++;

                txtName.ResetText();
                dtDob.ResetText();
                rbFemale.ResetText();
                cbStyle.ResetText();
                pbImage.Image = null;


            }catch(Exception x)
            {
                MessageBox.Show("Error accurred");
            }

        }

        private void AddArtist_Load(object sender, EventArgs e)
        {
           
        }
    }
}
