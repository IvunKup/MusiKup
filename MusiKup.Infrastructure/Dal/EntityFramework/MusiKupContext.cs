using Microsoft.EntityFrameworkCore;
using MusiKup.Domain.Entities;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Infrusructure.Dal.EntityFramework;

public class MusiKupContext : DbContext
{
    public DbSet<Author> Authors => Set<Author>();

    public DbSet<Performer> Performers => Set<Performer>();

    public DbSet<Playlist> Playlists => Set<Playlist>();

    public DbSet<Track> Tracks => Set<Track>();

    public DbSet<User> Users => Set<User>();

    public DbSet<BaseFile> Files => Set<BaseFile>();

    public MusiKupContext(DbContextOptions<MusiKupContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MusiKupContext).Assembly);
    }
}