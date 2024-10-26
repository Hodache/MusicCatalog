using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Models.MusicCollections;
using MusicCatalog.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MusicCatalog.ViewModels.CreationViewModels
{
    internal class AlbumCreationViewModel : INotifyPropertyChanged
    {
        private readonly MusicCatalogContext db;
        private TrackMediator trackMeidator;

        private string _titleFieldValue;
        public string TitleFieldValue
        {
            get => _titleFieldValue;
            set
            {
                _titleFieldValue = value;
                OnPropertyChanged(nameof(TitleFieldValue));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private Artist _artistFieldValue;
        public Artist ArtistFieldValue
        {
            get => _artistFieldValue;
            set
            {
                _artistFieldValue = value;
                List<Track> clearedTracks = TracksList.ToList();
                clearedTracks.RemoveAll(t => !t.Artists.Contains(value));
                TracksList = new ObservableCollection<Track>(clearedTracks);
                OnPropertyChanged(nameof(ArtistFieldValue));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private DateTime? _dateFieldValue;
        public DateTime? DateFieldValue
        {
            get => _dateFieldValue;
            set
            {
                _dateFieldValue = value;
                OnPropertyChanged(nameof(DateFieldValue));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private Genre _genreFieldValue;
        public Genre GenreFieldValue
        {
            get => _genreFieldValue;
            set
            {
                _genreFieldValue = value;
                OnPropertyChanged(nameof(GenreFieldValue));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<Track> _tracksList = new ObservableCollection<Track>();
        public ObservableCollection<Track> TracksList
        {
            get => _tracksList;
            set
            {
                _tracksList = value;
                OnPropertyChanged(nameof(TracksList));
                CreateCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<Artist> _artists;
        public ObservableCollection<Artist> Artists
        {
            get => _artists;
            private set
            {
                _artists = value;
                OnPropertyChanged(nameof(Artists));
            }
        }

        private ObservableCollection<Genre> _genres;
        public ObservableCollection<Genre> Genres
        {
            get => _genres;
            private set
            {
                _genres = value;
                OnPropertyChanged(nameof(Genres));
            }
        }

        public RelayCommand CreateCommand { get; set; }
        public ICommand UpdateArtistsListCommand { get; set; }
        public ICommand UpdateGenresListCommand { get; set; }

        public AlbumCreationViewModel(MusicCatalogContext context, TrackMediator mediator)
        {
            db = context;
            trackMeidator = mediator;
            trackMeidator.TrackAdded += track => 
            {
                // Если существующий трек не принадлежит артисту
                if (track.Id != 0 && !track.Artists.Contains(ArtistFieldValue)) 
                    return;

                if (TracksList.Any(t => 
                    (t.Title == track.Title && track.Id == 0) // От повторных новых треков
                    || (t.Id == track.Id && t.Id != 0) // От повторных существующих
                    )) return;

                TracksList.Add(track);
                CreateCommand.RaiseCanExecuteChanged();
            };

            CreateCommand = new RelayCommand(ExecuteCreate, CanExecuteCreate);
            UpdateArtistsListCommand = new RelayCommand(ExecuteUpdateArtists);
            UpdateGenresListCommand = new RelayCommand(ExecuteUpdateGenres);
        }

        private void ExecuteCreate()
        {
            foreach (var track in TracksList)
            {
                if (!track.Artists.Contains(ArtistFieldValue))
                {
                    track.Artists.Insert(0, ArtistFieldValue);
                }
            }

            Album album = new Album
            {
                Title = TitleFieldValue,
                Artist = ArtistFieldValue,
                ReleaseDate = DateFieldValue ?? DateTime.Now,
                Genre = GenreFieldValue,
                Tracks = TracksList.ToList()
            };

            db.Albums.Add(album);
            db.SaveChanges();
        }

        private bool CanExecuteCreate()
        {
            return !string.IsNullOrWhiteSpace(TitleFieldValue) 
                && DateFieldValue != null
                && ArtistFieldValue != null 
                && GenreFieldValue != null 
                && TracksList.Count > 0;
        }

        private void ExecuteUpdateArtists()
        {
            Artists = new ObservableCollection<Artist>(db.Artists.ToList());
        }

        private void ExecuteUpdateGenres()
        {
            Genres = new ObservableCollection<Genre>(db.Genres.ToList());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
