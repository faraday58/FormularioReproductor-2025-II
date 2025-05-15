namespace FormularioReproductor_2025_II
{
    public partial class Form1 : Form
    {
        List<Music> songs;
        public Form1()
        {
            InitializeComponent();
            LoadSongs();
        }

        private void LoadSongs()
        {
            songs = new List<Music>();

            songs.Add(new Music("Easy Lover", "Phil Collins", "Chinese Wall", @"C:\Users\Armando\source\repos\FormularioReproductor-2025-II\Resources\chinese_wall.jpg"));
            songs.Add(new Music("Enemy", "Imagine Dragons", " Mercury - Act 1&2", @"C:\Users\Armando\source\repos\FormularioReproductor-2025-II\Resources\Mercury.jpg"));
            songs.Add(new Music("505", "Artic Monkeys", "Favourite Worst Nigthmare", @"C:\Users\Armando\source\repos\FormularioReproductor-2025-II\Resources\favourite_worst_nightmare.jpg"));
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
