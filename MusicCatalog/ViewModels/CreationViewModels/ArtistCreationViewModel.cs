using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Services;
using System.ComponentModel;

namespace MusicCatalog.ViewModels.CreationViewModels
{
    internal class ArtistCreationViewModel : INotifyPropertyChanged
    {
        private readonly MusicCatalogContext db = new MusicCatalogContext();

        private string _nameFieldValue;
        public string NameFieldValue
        {
            get => _nameFieldValue;
            set
            {
                _nameFieldValue = value;
                OnPropertyChanged(nameof(NameFieldValue));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private string _countryFieldValue;
        public string CountryFieldValue
        {
            get => _countryFieldValue;
            set
            {
                _countryFieldValue = value;
                OnPropertyChanged(nameof(CountryFieldValue));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private bool isActiveValue;
        public bool IsActiveValue
        {
            get => isActiveValue;
            set
            {
                isActiveValue = value;
                OnPropertyChanged(nameof(IsActiveValue));
            }
        }

        public RelayCommand CreateCommand { get; set; }

        public ArtistCreationViewModel()
        {
            CreateCommand = new RelayCommand(ExecuteCreate, CanExecuteCreate);
        }

        private void ExecuteCreate()
        {
            Artist artist = new Artist
            {
                Name = NameFieldValue,
                Country = CountryFieldValue,
                IsActive = IsActiveValue
            };
            db.Artists.Add(artist);
            db.SaveChanges();
        }
        private bool CanExecuteCreate()
        {
            return !string.IsNullOrWhiteSpace(NameFieldValue) && !string.IsNullOrWhiteSpace(CountryFieldValue);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
