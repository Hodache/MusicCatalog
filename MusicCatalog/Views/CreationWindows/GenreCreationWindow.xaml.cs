using MusicCatalog.ViewModels.CreationViewModels;
using System.Windows;

namespace MusicCatalog.Views.CreationWindows
{
    /// <summary>
    /// Логика взаимодействия для GenreCreationWindow.xaml
    /// </summary>
    public partial class GenreCreationWindow : Window
    {
        public GenreCreationWindow()
        {
            InitializeComponent();
            DataContext = new GenreCreationViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
