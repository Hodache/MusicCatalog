namespace MusicCatalog.Models.MusicCollections
{
    class Playlist(string name, List<Track> tracks, string description, DateTime lastUpdate)  : MusicCollection(name, tracks)
    {
        public string Description { get; } = description;
        public DateTime LastUpdate { get; } = lastUpdate;
    }
}
