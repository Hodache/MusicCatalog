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

        public string GetMusicObjectType() => "Трек";
        public string GetName() => Title;
        public string getFirstInfo() => string.Join(", ", Artists.Select(item => item.Name));
        public string getSecondInfo() => $"{Duration} секунд";
        public string getAssociatedLabel() => "Связанные альбомы и плейлисты";
        public Dictionary<string, IMusicCatalogObject> getAssociatedObjects()
        {
            Dictionary<string, IMusicCatalogObject> associatedObjects = new();
            foreach (var album in Albums)
            {
                associatedObjects.Add(album.Title, album);
            }
            foreach (var playlist in Playlists)
            {
                associatedObjects.Add(playlist.Title, playlist);
            }
            return associatedObjects;
        }
    }
}
