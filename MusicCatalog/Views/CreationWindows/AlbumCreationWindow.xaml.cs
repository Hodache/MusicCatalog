using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Services;
using MusicCatalog.ViewModels.CreationViewModels;
using System.Windows;

namespace MusicCatalog.Views.CreationWindows
{
    /// <summary>
    /// Логика взаимодействия для AlbumCreationWindow.xaml
    /// </summary>
    public partial class AlbumCreationWindow : Window
    {
        MusicCatalogContext context = new MusicCatalogContext();
        private TrackMediator trackMediator = new TrackMediator();

        public AlbumCreationWindow()
        {
            InitializeComponent();
            DataContext = new AlbumCreationViewModel(context, trackMediator);
        }

        private void NewTrackButton_Click(object sender, RoutedEventArgs e)
        {
            Artist albumArtist = (DataContext as AlbumCreationViewModel).ArtistFieldValue;
            TrackCreationWindow trackCreationWindow = new TrackCreationWindow(context, trackMediator);
            trackCreationWindow.Owner = this;
            trackCreationWindow.Show();
        }

        private void ExistingTrackButton_Click(object sender, RoutedEventArgs e)
        {
            Artist albumArtist = (DataContext as AlbumCreationViewModel).ArtistFieldValue;
            ExistingTrackChoiceWindow existingTrackWindow = new ExistingTrackChoiceWindow(context, trackMediator);
            existingTrackWindow.Owner = this;
            existingTrackWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Window window in OwnedWindows)
            {
                window.Close();
            }
        }
    }
}
