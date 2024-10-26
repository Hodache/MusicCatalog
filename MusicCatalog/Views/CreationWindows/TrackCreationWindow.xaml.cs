using MusicCatalog.Data;
using MusicCatalog.Services;
using MusicCatalog.ViewModels.CreationViewModels;
using System.Windows;
namespace MusicCatalog.Views.CreationWindows
{
    /// <summary>
    /// Логика взаимодействия для TrackCreationWindow.xaml
    /// </summary>
    public partial class TrackCreationWindow : Window
    {
        public TrackCreationWindow(MusicCatalogContext context, TrackMediator trackMediator)
        {
            InitializeComponent();
            DataContext = new TrackCreationViewModel(context, trackMediator);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
