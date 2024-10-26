using MusicCatalog.Data;
using MusicCatalog.Models.MusicCollections;
using MusicCatalog.Models;
using MusicCatalog.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MusicCatalog.ViewModels.CreationViewModels
{
    internal class PlaylistCreationViewModel : INotifyPropertyChanged
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

        private string _descriptionFieldValue;
        public string DescriptionFieldValue
        {
            get => _descriptionFieldValue;
            set
            {
                _descriptionFieldValue = value;
                OnPropertyChanged(nameof(DescriptionFieldValue));
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

        public RelayCommand CreateCommand { get; set; }

        public PlaylistCreationViewModel(MusicCatalogContext context, TrackMediator mediator)
        {
            db = context;
            trackMeidator = mediator;
            trackMeidator.TrackAdded += track =>
            {
                // От повторных существующих треков
                if (TracksList.Any(t =>(t.Id == track.Id && t.Id != 0))) 
                    return;

                TracksList.Add(track);
                CreateCommand.RaiseCanExecuteChanged();
            };

            CreateCommand = new RelayCommand(ExecuteCreate, CanExecuteCreate);
        }

        private void ExecuteCreate()
        {
            Playlist playlist = new Playlist
            {
                Title = TitleFieldValue,
                Description = DescriptionFieldValue,
                LastUpdate = DateFieldValue ?? DateTime.Now,
                Tracks = TracksList.ToList()
            };

            db.Playlists.Add(playlist);
            db.SaveChanges();
        }

        private bool CanExecuteCreate()
        {
            return !string.IsNullOrWhiteSpace(TitleFieldValue)
                && !string.IsNullOrWhiteSpace(DescriptionFieldValue)
                && DateFieldValue != null
                && TracksList.Count > 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
