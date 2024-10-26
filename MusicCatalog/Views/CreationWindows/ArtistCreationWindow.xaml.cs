using MusicCatalog.ViewModels.CreationViewModels;
using System.Windows;
namespace MusicCatalog.Views.CreationWindows
{
    /// <summary>
    /// Логика взаимодействия для ArtistCreationWindow.xaml
    /// </summary>
    public partial class ArtistCreationWindow : Window
    {
        public ArtistCreationWindow()
        {
            InitializeComponent();
            DataContext = new ArtistCreationViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
