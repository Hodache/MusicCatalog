using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.Services;
using MusicCatalog.ViewModels.CreationViewModels;
using System.Windows;

namespace MusicCatalog.Views.CreationWindows
{
    /// <summary>
    /// Логика взаимодействия для PlaylistCreationWindow.xaml
    /// </summary>
    public partial class PlaylistCreationWindow : Window
    {
        MusicCatalogContext context = new MusicCatalogContext();
        TrackMediator trackMediator = new TrackMediator();

        public PlaylistCreationWindow()
        {
            InitializeComponent();
            DataContext = new PlaylistCreationViewModel(context, trackMediator);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
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
