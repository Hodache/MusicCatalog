namespace MusicCatalog.Models.MusicCollections
{
    abstract class MusicCollection(string name, List<Track> tracks)
    {
        public string Title { get; } = name;
        public List<Track> Tracks { get; } = tracks;
    }
}
