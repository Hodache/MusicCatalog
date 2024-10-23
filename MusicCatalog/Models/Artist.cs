using MusicCatalog.Models.MusicCollections;

namespace MusicCatalog.Models
{
    public class Artist() : IMusicCatalogObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Country { get; set; }
        public bool IsActive { get; set; } 

        public List<Track> Tracks { get; set; } = new();
        public List<Album> Albums { get; set; } = new();

        public string GetMusicObjectType() => "Артист";
        public string GetName() => Name;
        public string getFirstInfo() => Country ?? "";
        public string getSecondInfo() => IsActive ? "Активен" : "Неактивен";
        public string getAssociatedLabel() => "Выпущенные альбомы";
        public Dictionary<string, IMusicCatalogObject> getAssociatedObjects()
        {
            Dictionary<string, IMusicCatalogObject> associatedObjects = new();
            foreach (var album in Albums)
            {
                associatedObjects.Add(album.Title, album);
            }
            return associatedObjects;
        }
    }
}
