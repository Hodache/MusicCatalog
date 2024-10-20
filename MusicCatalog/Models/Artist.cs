namespace MusicCatalog.Models
{
    public class Artist()
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Country { get; set; }
        public bool? IsActive { get; set; } 
        public List<Track> Tracks { get; set; } = new();
    }
}
