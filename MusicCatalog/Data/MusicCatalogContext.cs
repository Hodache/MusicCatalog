using MusicCatalog.Models;
using MusicCatalog.Models.MusicCollections;
using Microsoft.EntityFrameworkCore;

namespace MusicCatalog.Data;

public class MusicCatalogContext : DbContext
{
    public DbSet<Track> Tracks { get; set; } = null!;
    public DbSet<Artist> Artists { get; set; } = null!;
    public DbSet<MusicCollection> MusicCollections { get; set; } = null!;
    public DbSet<Album> Albums { get; set; } = null!;
    public DbSet<Playlist> Playlists { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;

    public MusicCatalogContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MusicCatalog;Trusted_Connection=True;");
    }
}
