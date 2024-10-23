namespace MusicCatalog.Models.MusicCollections
{
    public class Album : MusicCollection, IMusicCatalogObject
    {
        public Artist Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        public string GetMusicObjectType() => Tracks.Count == 1 ? "Сингл" : "Альбом";
        public string GetName() => Title;
        public string getFirstInfo() => Artist.Name;
        public string getSecondInfo() => $"{ReleaseDate:yyyy} - {Genre.Name}";
        public string getAssociatedLabel() => "Вошедшие треки";
        public Dictionary<string, IMusicCatalogObject> getAssociatedObjects()
        {
            Dictionary<string, IMusicCatalogObject> associatedObjects = new();
            foreach (var track in Tracks)
            {
                associatedObjects.Add($"{track.Title} - {track.Duration}", track);
            }
            return associatedObjects;
        }

    }
}
