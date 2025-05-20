using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioReproductor_2025_II
{
    public partial class FormAgregar : Form
    {

        internal delegate void DAddSong(Music music);
        internal event DAddSong AddSongEvent;

        private string path = "";

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Music miMusic = new Music(
                txtbTitle.Text,
                txtbArtist.Text,
                txtbAlbum.Text,
                path
                );

            AddSongEvent(miMusic);
        }

        private void ptbLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;   
            }

        }
    }
}
