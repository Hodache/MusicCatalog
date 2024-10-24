using MusicCatalog.Models.MusicCollections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        public string Designation => Name;
        public string CatalogObjectType => "Артист";
        public string FirstInfo => Country ?? "";
        public string SecondInfo => IsActive ? "Активен" : "Неактивен";
        public string AssociatedLabel => "Выпущенные альбомы";
        public List<IMusicCatalogObject> AssociatedObjects => Albums.Cast<IMusicCatalogObject>().ToList();
    }
}
