
namespace FormularioReproductor_2025_II
{
    class Music
    {
        #region Attributes  
        private string title;
        private string artist;
        private string album;
        private string pathAlbum;
       
        #endregion


        #region Properties
        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Album { get => album; set => album = value; }
        public string PathAlbum { get => pathAlbum; set => pathAlbum = value; }
        #endregion


        #region Constructors
        public Music(string title, string artist, string album, string pathAlbum)
        {
            Title = title;
            Artist = artist;
            Album = album;
            this.pathAlbum = pathAlbum;
        }
        #endregion

    }
}
