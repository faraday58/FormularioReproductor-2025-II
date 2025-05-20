namespace FormularioReproductor_2025_II
{
    public partial class Form1 : Form
    {
        List<Music> songs;
        public Form1()
        {
            InitializeComponent();
            songs = new List<Music>();
        }

        private void LoadSongs()
        {


            songs.Add(new Music("Easy Lover", "Phil Collins", "Chinese Wall", @"..\..\..\Resources\chinese_wall.jpg"));
            songs.Add(new Music("Enemy", "Imagine Dragons", " Mercury - Act 1&2", @"..\..\..\Resources\Mercury.jpg"));
            songs.Add(new Music("505", "Artic Monkeys", "Favourite Worst Nigthmare", @"..\..\..\Resources\favourite_worst_nightmare.jpg"));
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSongs();
            foreach (var song in songs)
            {
                lstbRepro.Items.Add(song.Title);
            }
        }

        private void lstbRepro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Music song = songs[lstbRepro.SelectedIndex];
            lbArtist.Text = song.Artist;
            lbTitle.Text = song.Title;
            lbAlbum.Text = song.Album;
            ptbAlbum.Image = Image.FromFile(song.PathAlbum);
        }


        private void receivedSong(Music music)
        {
            songs.Add(music);
            lstbRepro.Items.Add(music.Title);

        }

        private void agregarCanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.AddSongEvent += receivedSong;
            formAgregar.ShowDialog();

        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private int tiempo = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            prbarTime.Value = tiempo;

            tiempo++;

            if (tiempo == 140)
            {
                timer1.Stop();
                tiempo = 0;
            }
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tiempo = 0;
            prbarTime.Value = 0;
        }
    }
}
