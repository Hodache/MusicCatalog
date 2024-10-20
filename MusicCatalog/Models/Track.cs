using MusicCatalog.Models.MusicCollections;

namespace MusicCatalog.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public List<Artist> Artists { get; set; }

        public List<Album> Albums { get; set; } = new();
        public List<Playlist> Playlists { get; set; } = new();

    }
}
