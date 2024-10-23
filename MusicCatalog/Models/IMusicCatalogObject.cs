namespace MusicCatalog.Models
{
    public interface IMusicCatalogObject
    {
        public string GetMusicObjectType();
        public string GetName();
        public string getFirstInfo();
        public string getSecondInfo();
        public string getAssociatedLabel();
        public Dictionary<string, IMusicCatalogObject> getAssociatedObjects();
    }
}
