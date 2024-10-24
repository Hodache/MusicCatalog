using Microsoft.EntityFrameworkCore;
using MusicCatalog.Models;
using MusicCatalog.Models.MusicCollections;

namespace MusicCatalog.Data
{
    static class SearchEngine
    {
        public static IQueryable<Artist>? GetArtists(MusicCatalogContext context, string? searchString, Genre? genre, int? startYear, int? endYear)
        {
            if (string.IsNullOrWhiteSpace(searchString))
            {
                return null;
            }

            IQueryable<Artist> query = context.Artists
                .Include(a => a.Albums)
                .Where(a => a.Name.Contains(searchString));

            if (genre != null)
            {
                query = query.Where(a => a.Albums.Any(al => al.Genre == genre));
            }

            if (startYear != null)
            {
                query = query.Where(a => a.Albums.Any(al => al.ReleaseDate.Year >= startYear));
            }

            if (endYear != null)
            {
                query = query.Where(a => a.Albums.Any(al => al.ReleaseDate.Year <= endYear));
            }

            return query;
        }

        public static IQueryable<Track>? GetTracks(MusicCatalogContext context, string? searchString, Genre? genre, int? startYear, int? endYear, int? minDuration, int? maxDuration)
        {
            if (string.IsNullOrWhiteSpace(searchString))
            {
                return null;
            }

            IQueryable<Track> query = context.Tracks
                .Include(t => t.Albums)
                .Include(t => t.Playlists)
                .Include(t => t.Artists)
                .Where(t => t.Title.Contains(searchString));

            if (genre != null)
            {
                query = query.Where(t => t.Albums.Any(al => al.Genre == genre));
            }

            if (startYear != null) {
                query = query.Where(t => t.Albums.Any(al => al.ReleaseDate.Year >= startYear));
            }

            if (endYear != null) {
                query = query.Where(t => t.Albums.Any(al => al.ReleaseDate.Year <= endYear));
            }

            if (minDuration != null) {
                query = query.Where(t => t.Duration >= minDuration);
            }

            if (maxDuration != null)
            {
                query = query.Where(t => t.Duration <= maxDuration);
            }

            return query;
        }

        public static IQueryable<Album>? GetAlbums(MusicCatalogContext context, string? searchString, Genre? genre, int? startYear, int? endYear)
        {
            if (string.IsNullOrWhiteSpace(searchString))
            {
                return null;
            }

            IQueryable<Album> query = context.Albums
                .Include(a => a.Tracks)
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .Where(a => a.Title.Contains(searchString));

            if (genre != null)
            {
                query = query.Where(a => a.Genre == genre);
            }

            if (startYear != null)
            {
                query = query.Where(a => a.ReleaseDate.Year >= startYear);
            }

            if (endYear != null)
            {
                query = query.Where(a => a.ReleaseDate.Year <= endYear);
            }

            return query;
        }

        public static IQueryable<Playlist>? GetPlaylists(MusicCatalogContext context, string? searchString, int? startYear, int? endYear)
        {
            if (string.IsNullOrWhiteSpace(searchString))
            {
                return null;
            }

            IQueryable<Playlist> query = context.Playlists
                .Include(a => a.Tracks)
                .Where(p => p.Title.Contains(searchString));

            if (startYear != null)
            {
                query = query.Where(a => a.LastUpdate.Year >= startYear);
            }

            if (endYear != null)
            {
                query = query.Where(a => a.LastUpdate.Year <= endYear);
            }

            return query;
        }
    }
}
