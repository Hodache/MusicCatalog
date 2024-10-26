using MusicCatalog.Models.MusicCollections;
using MusicCatalog.Models;
using MusicCatalog.ViewModels;
using System.Windows;
using MusicCatalog.Data;
using System.Windows.Controls;
using MusicCatalog.Views;
using System.Collections.ObjectModel;
using MusicCatalog.Views.CreationWindows;

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
            DataContext = new MainViewModel();

            //Genre rock = new Genre { Name = "Rock" };
            //Genre pop = new Genre { Name = "Pop" };

            //Artist queen = new Artist { Name = "Queen", Country = "UK", IsActive = true };
            //Artist rukiVverh = new Artist { Name = "Руки Вверх", Country = "Russia", IsActive = false };

            //Track queen1 = new Track { Title = "Bohemian Rhapsody", Duration = 367, Artists = [queen] };
            //Track queen2 = new Track { Title = "We Will Rock You", Duration = 122, Artists = [ queen, rukiVverh ] };
            //Track queen3 = new Track { Title = "We Are the Champions", Duration = 180, Artists = [ queen ] };

            //Track rukiVverh1 = new Track { Title = "18 мне уже", Duration = 240, Artists = [ rukiVverh ] };
            //Track rukiVverh2 = new Track { Title = "Крошка моя", Duration = 210, Artists = [ rukiVverh, queen ] };

            //Album queenAlbum1 = new Album { Title = "A Night at the Opera", Artist = queen, ReleaseDate = new DateTime(1975, 11, 21), Genre = rock };
            //Album queenAlbum2 = new Album { Title = "News of the World", Artist = queen, ReleaseDate = new DateTime(1977, 10, 28), Genre = pop };

            //Album rukiVverhAlbum1 = new Album { Title = "18 мне уже", Artist = rukiVverh, ReleaseDate = new DateTime(1998, 1, 1), Genre = pop };
            //Album rukiVverhAlbum2 = new Album { Title = "Дышите равномерно", Artist = rukiVverh, ReleaseDate = new DateTime(1999, 1, 1), Genre = rock };

            //Playlist playlist1 = new Playlist { Title = "Подборка редакции", Description = "Понравившееся нам", LastUpdate = new DateTime(2022, 5, 16) };
            //Playlist playlist2 = new Playlist { Title = "Подборка пользователей", Description = "Понравившееся пользователям", LastUpdate = new DateTime(2024, 10, 24) };

            //queenAlbum1.Tracks.AddRange([queen1, queen2, queen3]);
            //queenAlbum2.Tracks.Add(queen2);

            //rukiVverhAlbum1.Tracks.Add(rukiVverh1);
            //rukiVverhAlbum2.Tracks.AddRange([rukiVverh1, rukiVverh2]);

            //playlist1.Tracks.AddRange([queen1, queen3, rukiVverh1, rukiVverh2]);
            //playlist2.Tracks.AddRange([queen2, rukiVverh2]);


            //db.Genres.AddRange([rock, pop]);
            //db.Artists.AddRange([queen, rukiVverh]);
            //db.Tracks.AddRange([queen1, queen2, queen3, rukiVverh1, rukiVverh2]);
            //db.Albums.AddRange([queenAlbum1, queenAlbum2, rukiVverhAlbum1, rukiVverhAlbum2]);
            //db.Playlists.AddRange([playlist1, playlist2]);

            //db.SaveChanges();
        }

        private void ListBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

                CatalogObjectWindow catalogObjectWindow = new CatalogObjectWindow((sender as ListBox).SelectedItem as IMusicCatalogObject);
                catalogObjectWindow.Show();
        }

        private void ArtistCreationButton_Click(object sender, RoutedEventArgs e)
        {
            ArtistCreationWindow artistCreationWindow = new();
            artistCreationWindow.Owner = this;
            artistCreationWindow.Show();
        }

        private void GenreCreationButton_Click(object sender, RoutedEventArgs e)
        {
            GenreCreationWindow genreCreationWindow = new();
            genreCreationWindow.Owner = this;
            genreCreationWindow.Show();
        }

        private void AlbumCreationButton_Click(object sender, RoutedEventArgs e)
        {
            AlbumCreationWindow albumCreationWindow = new();
            albumCreationWindow.Owner = this;
            albumCreationWindow.Show();
        }

        private void PlaylistCreationButton_Click(object sender, RoutedEventArgs e)
        {
            PlaylistCreationWindow playlistCreationWindow = new();
            playlistCreationWindow.Owner = this;
            playlistCreationWindow.Show();
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