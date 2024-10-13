namespace MusicCatalog.Models
{
    class Track(string name, List<Artist> artists, int duration, Genre genre)
    {
        public string Title { get; } = name;
        public List<Artist> Artists { get; } = artists;
        public int Duration { get; } = duration;
        public Genre Genre { get; } = genre;
    }
}
