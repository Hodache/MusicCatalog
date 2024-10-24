using System.ComponentModel.DataAnnotations.Schema;

namespace MusicCatalog.Models.MusicCollections
{
    [Table("Albums")]
    public class Album : MusicCollection, IMusicCatalogObject
    {
        public Artist Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        public List<Track> Tracks { get; set; } = new();

        public string CatalogObjectType => Tracks.Count == 1 ? "Сингл" : "Альбом";
        public string Designation => Title;
        public string FirstInfo => Artist.Name;
        public string SecondInfo => $"{ReleaseDate:yyyy} - {Genre.Name}";
        public string AssociatedLabel => "Вошедшие треки";
        public List<IMusicCatalogObject> AssociatedObjects => Tracks.Cast<IMusicCatalogObject>().ToList();

    }
}
