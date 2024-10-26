using Microsoft.EntityFrameworkCore;
using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MusicCatalog.ViewModels.CreationViewModels
{
    internal class ExistingTrackChoiceViewModel : INotifyPropertyChanged
    {
        private readonly MusicCatalogContext db;
        private TrackMediator trackMediator;

        private Track _selectedTrack;
        public Track SelectedTrack
        {
            get => _selectedTrack;
            set
            {
                _selectedTrack = value;
                OnPropertyChanged(nameof(SelectedTrack));
                AddToAlbumCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<Track> _tracks = new ObservableCollection<Track>();
        public ObservableCollection<Track> Tracks
        {
            get => _tracks;
            private set
            {
                _tracks = value;
                OnPropertyChanged(nameof(Tracks));
            }
        }

        private string _trackSearchText;
        public string TrackSearchText
        {
            get => _trackSearchText;
            set
            {
                _trackSearchText = value;
                OnPropertyChanged(nameof(TrackSearchText));
                UpdateTracksListCommand.Execute(null);
            }
        }

        public RelayCommand UpdateTracksListCommand { get; set; }
        public RelayCommand AddToAlbumCommand { get; set; }

        public ExistingTrackChoiceViewModel(MusicCatalogContext context, TrackMediator mediator)
        {
            db = context;
            trackMediator = mediator;

            UpdateTracksListCommand = new RelayCommand(ExecuteUpdateTracks, CanExecuteUpdateTracks);
            AddToAlbumCommand = new RelayCommand(ExecuteAddToAlbum, CanExecuteAddToAlbum);
        }

        private void ExecuteUpdateTracks()
        {
            Tracks = new ObservableCollection<Track>(db.Tracks
                .Include(t => t.Artists)
                .Where(t => t.Title.Contains(TrackSearchText)));
        }

        private bool CanExecuteUpdateTracks()
        {
            return !string.IsNullOrWhiteSpace(TrackSearchText);
        }

        private void ExecuteAddToAlbum()
        {
            trackMediator.AddTrack(SelectedTrack);
        }

        private bool CanExecuteAddToAlbum()
        {
            return SelectedTrack != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
