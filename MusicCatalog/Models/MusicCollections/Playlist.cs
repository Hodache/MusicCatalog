namespace MusicCatalog.Models.MusicCollections
{
    public class Playlist  : MusicCollection, IMusicCatalogObject
    { 
        public string? Description { get; set; }
        public DateTime LastUpdate { get; set; }

        public string GetMusicObjectType() => "Плейлист";
        public string GetName() => Title;
        public string getFirstInfo() => Description ?? "Описание отсутствует";
        public string getSecondInfo() => $"Последнее обновление: {LastUpdate:dd.MM.yyyy}";
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
