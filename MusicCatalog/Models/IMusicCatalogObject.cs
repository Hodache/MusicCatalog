namespace MusicCatalog.Models
{
    public interface IMusicCatalogObject
    {
        public string CatalogObjectType { get; }
        public string Designation { get; }
        public string FirstInfo { get; }
        public string SecondInfo { get; }
        public string AssociatedLabel { get; }
        public List<IMusicCatalogObject> AssociatedObjects { get; }
    }
}
