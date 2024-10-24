using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Models.MusicCollections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MusicCatalog.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private readonly MusicCatalogContext db;

        private ObservableCollection<IMusicCatalogObject> _searchResults;
        public ObservableCollection<IMusicCatalogObject> SearchResults
        {
            get => _searchResults;
            private set
            {
                _searchResults = value;
                OnPropertyChanged(nameof(SearchResults));
            }
        }
        private ObservableCollection<Genre> _genres;
        public ObservableCollection<Genre> Genres
        {
            get { return _genres; }
            private set
            {
                _genres = value;
                OnPropertyChanged(nameof(Genres));
            }
        }

        private IMusicCatalogObject _selectedCatalogObject;
        public IMusicCatalogObject SelectedCatalogObject
        {
            get { return _selectedCatalogObject; }
            set
            {
                _selectedCatalogObject = value;
                OnPropertyChanged(nameof(SelectedCatalogObject));
            }
        }

        private string _searchText;
        private Genre? _selectedGenre;
        private int? _startYear;
        private int? _endYear;
        private int? _minDuration;
        private int? _maxDuration;

        public ICommand SearchCommand { get; set; }
        public ICommand UpdateGenresListCommand { get; set; }

        public MainViewModel(MusicCatalogContext db)
        {
            this.db = db;
            SearchCommand = new RelayCommand(ExecuteSearch);
            UpdateGenresListCommand = new RelayCommand(UpdateGenresExecute);
        }

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        public Genre? SelectedGenre
        {
            get { return _selectedGenre; }
            set
            {
                if (value.Name == "Любой") value = null;
                _selectedGenre = value;
                OnPropertyChanged(nameof(SelectedGenre));
            }
        }

        public int? StartYear
        {
            get { return _startYear ?? 0; }
            set
            {
                _startYear = value;
                OnPropertyChanged(nameof(StartYear));
            }
        }

        public int? EndYear
        {
            get { return _endYear ?? 2025; }
            set
            {
                if (!value.HasValue) return;
                _endYear = value;
                OnPropertyChanged(nameof(EndYear));
            }
        }

        public int? MinDuration
        {
            get { return _minDuration ?? 0; }
            set
            {
                if (!value.HasValue) return;
                _minDuration = value;
                OnPropertyChanged(nameof(MinDuration));
            }
        }

        public int? MaxDuration
        {
            get { return _maxDuration ?? 600; }
            set
            {
                if (!value.HasValue) return;
                _maxDuration = value;
                OnPropertyChanged(nameof(MaxDuration));
            }
        }

        private void ExecuteSearch()
        {
            SearchResults = new ObservableCollection<IMusicCatalogObject>();

            IQueryable<Artist>? artists = SearchEngine.GetArtists(db, SearchText, SelectedGenre, StartYear, EndYear);
            if(artists != null)
            {
                foreach (var artist in artists)
                {
                    SearchResults.Add(artist);
                }
            }

            IQueryable<Track>? tracks = SearchEngine.GetTracks(db, SearchText, SelectedGenre, StartYear, EndYear, MinDuration, MaxDuration);
            if (tracks != null)
            {
                foreach (var track in tracks)
                {
                    SearchResults.Add(track);
                }
            }

            IQueryable<Album>? albums = SearchEngine.GetAlbums(db, SearchText, SelectedGenre, StartYear, EndYear);
            if (albums != null)
            {
                foreach (var album in albums)
                {
                    SearchResults.Add(album);
                }
            }

            IQueryable<Playlist>? playlists = SearchEngine.GetPlaylists(db, SearchText, StartYear, EndYear);
            if (playlists != null)
            {
                foreach (var playlist in playlists)
                {
                    SearchResults.Add(playlist);
                }
            }
        }

        private void UpdateGenresExecute()
        {
            Genres = new ObservableCollection<Genre>(db.Genres.ToList());
            Genres.Insert(0, new Genre { Name = "Любой" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
