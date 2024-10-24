using System.ComponentModel.DataAnnotations.Schema;

namespace MusicCatalog.Models.MusicCollections
{
    [Table("Playlists")]
    public class Playlist  : MusicCollection, IMusicCatalogObject
    { 
        public string? Description { get; set; }
        public DateTime LastUpdate { get; set; }

        public List<Track> Tracks { get; set; } = new();

        public string CatalogObjectType => "Плейлист";
        public string Designation => Title;
        public string FirstInfo => Description ?? "Описание отсутствует";
        public string SecondInfo => $"Последнее обновление: {LastUpdate:dd.MM.yyyy}";
        public string AssociatedLabel => "Вошедшие треки";
        public List<IMusicCatalogObject> AssociatedObjects => Tracks.Cast<IMusicCatalogObject>().ToList();
    }
}
