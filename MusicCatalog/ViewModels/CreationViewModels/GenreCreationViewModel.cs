using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Services;
using System.ComponentModel;

namespace MusicCatalog.ViewModels.CreationViewModels
{
    class GenreCreationViewModel : INotifyPropertyChanged
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
        public RelayCommand CreateCommand { get; set; }

        public GenreCreationViewModel()
        {
            CreateCommand = new RelayCommand(ExecuteCreate, CanExecuteCreate);
        }

        private void ExecuteCreate()
        {
            Genre genre = new Genre
            {
                Name = NameFieldValue,
            };
            db.Genres.Add(genre);
            db.SaveChanges();
        }
        private bool CanExecuteCreate()
        {
            return !string.IsNullOrWhiteSpace(NameFieldValue);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
