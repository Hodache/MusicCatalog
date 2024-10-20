namespace MusicCatalog.Models.MusicCollections
{
    public class Playlist  : MusicCollection
    { 
        public string? Description { get; set; }
        public DateTime LastUpdate { get; set; } 
    }
}
