using MusicCatalog.Data;
using MusicCatalog.Services;
using MusicCatalog.ViewModels.CreationViewModels;
using System.Windows;

namespace MusicCatalog.Views.CreationWindows
{
    /// <summary>
    /// Логика взаимодействия для ExistingTrackChoiceWindow.xaml
    /// </summary>
    public partial class ExistingTrackChoiceWindow : Window
    {
        public ExistingTrackChoiceWindow(MusicCatalogContext context, TrackMediator trackMediator)
        {
            InitializeComponent();
            DataContext = new ExistingTrackChoiceViewModel(context, trackMediator);
        }
    }
}
