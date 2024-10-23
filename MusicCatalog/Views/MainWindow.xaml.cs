using Microsoft.VisualBasic.ApplicationServices;
using MusicCatalog.Data;
using MusicCatalog.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Track testTrack = new Track { Title = "Test", Duration = 153 };
            using (MusicCatalogContext db = new())
            {
                db.Tracks.Add(testTrack);
                db.SaveChanges();
            }
        }
    }
}