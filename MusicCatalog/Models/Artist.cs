namespace MusicCatalog.Models
{
    class Artist(string name, string country, bool isActive)
    {
        public string Name { get; } = name;
        public string Country { get; } = country;
        public bool IsActive { get; } = isActive;
    }
}
