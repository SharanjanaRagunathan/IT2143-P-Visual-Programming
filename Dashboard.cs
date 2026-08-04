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
    public partial class Dashboard : Form
    {

        Artist[] artists = new Artist[20];
        Art[] arts = new Art[20];
        int artCount = 0 ;
        int artistCount;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(Artist[] _artists)
        {

            InitializeComponent();
            this.artists = _artists;
            loadArtist();
        }

        public Dashboard(Artist[] _artists,Art[] _arts)
        {

            InitializeComponent();
 
            this.arts = _arts;
            this.artists = _artists;
            loadArtist();

            if (arts != null)
            {
                foreach (var art in arts)
                {

                    if (art != null)
                    {
                        comboBox1.Items.Add(art.Name);
                    }

                }
            }
        }


        private void loadArtist() {
           
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            AddArtist addArtist = new AddArtist();
            this.Hide();
            addArtist.Show();
        }

        private void btnAddArt_Click(object sender, EventArgs e)
        {
            AddArt addArt = new AddArt(artists);   
            this.Hide(); 
            addArt.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnViewArt_Click(object sender, EventArgs e)
        {
            ViewArt viewArt = new ViewArt(artists,arts);
            this.Hide();
            viewArt.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
