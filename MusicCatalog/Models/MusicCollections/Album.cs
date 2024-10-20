namespace MusicCatalog.Models.MusicCollections
{
    public class Album : MusicCollection
    {
        public Artist Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
    }
}
