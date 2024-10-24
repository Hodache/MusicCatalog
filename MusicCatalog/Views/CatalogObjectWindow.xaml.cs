using MusicCatalog.Data;
using MusicCatalog.Models;
using MusicCatalog.ViewModels;
using System.Windows;

namespace MusicCatalog.Views
{
    /// <summary>
    /// Логика взаимодействия для CatalogObjectWindow.xaml
    /// </summary>
    public partial class CatalogObjectWindow : Window
    {
        public CatalogObjectWindow(IMusicCatalogObject catalogObject)
        {
            InitializeComponent();
            DataContext = new CatalogObjectViewModel(catalogObject);
        }
    }
}
