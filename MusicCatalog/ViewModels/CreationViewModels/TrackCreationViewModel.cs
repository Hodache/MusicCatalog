using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MusicCatalog.ViewModels.CreationViewModels
{
    internal class TrackCreationViewModel : INotifyPropertyChanged
    {
        private readonly MusicCatalogContext db;
        private TrackMediator trackMediator;

        private string _titleFieldValue;
        public string TitleFieldValue
        {
            get => _titleFieldValue;
            set
            {
                _titleFieldValue = value;
                OnPropertyChanged(nameof(TitleFieldValue));
                AddToAlbumCommand.RaiseCanExecuteChanged();
            }
        }

        private int? _durationFieldValue;
        public int? DurationFieldValue
        {
            get => _durationFieldValue ?? 0;
            set
            {
                _durationFieldValue = value;
                OnPropertyChanged(nameof(DurationFieldValue));
                AddToAlbumCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<Artist> _authors = new ObservableCollection<Artist>();
        public ObservableCollection<Artist> Authors
        {
            get { return _authors; }
            private set
            {
                _authors = value;
                OnPropertyChanged(nameof(Authors));
            }
        }

        private Artist _selectedArtistFieldValue;
        public Artist SelectedArtistFieldValue
        {
            get => _selectedArtistFieldValue;
            set
            {
                _selectedArtistFieldValue = value;
                OnPropertyChanged(nameof(SelectedArtistFieldValue));
                AddAuthorCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<Artist> _artists;
        public ObservableCollection<Artist> Artists
        {
            get => _artists;
            set
            {
                _artists = value;
                OnPropertyChanged(nameof(Artists));
            }
        }

        public RelayCommand AddToAlbumCommand { get; set; }
        public ICommand UpdateArtistsListCommand { get; set; }
        public RelayCommand AddAuthorCommand { get; set; }

        public TrackCreationViewModel(MusicCatalogContext context, TrackMediator mediator)
        {
            db = context;
            trackMediator = mediator;

            AddToAlbumCommand = new RelayCommand(ExecuteAddToAlbum, CanExecuteAddToAlbum);
            UpdateArtistsListCommand = new RelayCommand(ExecuteUpdateArtists);
            AddAuthorCommand = new RelayCommand(ExecuteAddAuthor, CanExecuteAddAuthor);
        }

        private void ExecuteAddToAlbum()
        {
            Track track = new Track
            {
                Title = TitleFieldValue,
                Duration = DurationFieldValue ?? 0,
                Artists = Authors.ToList() ?? new List<Artist>()
            };

            trackMediator.AddTrack(track);
        }

        private bool CanExecuteAddToAlbum()
        {
            return !string.IsNullOrWhiteSpace(TitleFieldValue)
                && DurationFieldValue != null;
        }

        private void ExecuteUpdateArtists()
        {
            Artists = new ObservableCollection<Artist>(
                db.Artists
                .Where(a => !Authors.Contains(a))
                .ToList());
        }

        private void ExecuteAddAuthor()
        {
            if (Authors.Contains(SelectedArtistFieldValue)) return;

            Authors.Add(SelectedArtistFieldValue);
            OnPropertyChanged(nameof(Authors));
        }

        private bool CanExecuteAddAuthor()
        {
            return SelectedArtistFieldValue != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
