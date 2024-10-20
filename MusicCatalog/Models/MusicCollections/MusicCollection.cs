namespace MusicCatalog.Models.MusicCollections
{
    public abstract class MusicCollection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Track> Tracks { get; set; } = new();
    }
}
