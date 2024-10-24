using MusicCatalog.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MusicCatalog.ViewModels
{
    internal class CatalogObjectViewModel : INotifyPropertyChanged
    {
        private IMusicCatalogObject displayedCatalogObject;
        public IMusicCatalogObject DisplayedCatalogObject
        {
            get => displayedCatalogObject;
            set
            {
                displayedCatalogObject = value;
                OnPropertyChanged(nameof(DisplayedCatalogObject));
            }
        }

        private ObservableCollection<IMusicCatalogObject> _associatedCatalogObjects;
        public ObservableCollection<IMusicCatalogObject> AssociatedCatalogObjects
        {
            get => _associatedCatalogObjects;
            set
            {
                _associatedCatalogObjects = value;
                OnPropertyChanged(nameof(AssociatedCatalogObjects));
            }
        }

        public CatalogObjectViewModel(IMusicCatalogObject catalogObject)
        {
            DisplayedCatalogObject = catalogObject;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
