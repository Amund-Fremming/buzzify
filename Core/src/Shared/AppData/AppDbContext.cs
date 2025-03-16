using Core.src.Features.Spin;
using Core.src.Features.User;
using Microsoft.EntityFrameworkCore;

namespace Core.src.Shared.AppData;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<SpinGame> SpinGame { get; set; }
    public DbSet<SpinRound> SpinRound { get; set; }
    public DbSet<SpinChallenge> SpinChallenge { get; set; }
    public DbSet<SpinGamePlayer> SpinGamePlayer { get; set; }
    public DbSet<SpinRoundPlayer> SpinRoundPlayer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserEntity>()
            .HasKey(_ => _.Id);
    }
}