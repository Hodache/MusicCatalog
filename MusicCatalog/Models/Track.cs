using MusicCatalog.Models.MusicCollections;

namespace MusicCatalog.Models
{
    public class Track : IMusicCatalogObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public List<Artist> Artists { get; set; }

        public List<Album> Albums { get; set; } = new();
        public List<Playlist> Playlists { get; set; } = new();

        public string CatalogObjectType => "Трек";
        public string Designation => Title;
        public string FirstInfo => string.Join(", ", Artists.Select(item => item.Designation));
        public string SecondInfo => $"{Duration} секунд";
        public string AssociatedLabel => "Связанные коллекции";
        public List<IMusicCatalogObject> AssociatedObjects => Albums.Cast<IMusicCatalogObject>().Concat(Playlists).ToList();
    }
}
