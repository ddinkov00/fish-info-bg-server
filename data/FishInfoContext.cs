using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace data;

public class FishInfoContext(DbContextOptions<FishInfoContext> options)
    : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>(options)
{
    public DbSet<FishSpecies> FishSpecies { get; set; }

    public DbSet<CloseSeason> CloseSeasons { get; set; }

    public DbSet<Post> Posts { get; set; }

    public DbSet<Like> Likes { get; set; }

    public DbSet<PostImage> PostImages { get; set; }

    public DbSet<Region> Regions { get; set; }

    public DbSet<WaterSourceProhibitionMarker> WaterSourceProhibitionMarkers { get; set; }

    public DbSet<WaterSourceProhibition> WaterSourceProhibitions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=fish-info;Username=postgres;Password=mitaka1971;Persist Security Info=true;Include Error Detail=true");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        new FishSpeciesConfig().Configure(builder.Entity<FishSpecies>());
        new CloseSeasonConfig().Configure(builder.Entity<CloseSeason>());
        new RegionsConfig().Configure(builder.Entity<Region>());
        new WaterSourceProhibitionConfig().Configure(builder.Entity<WaterSourceProhibition>());
        new WaterSourceProhibitionMarkerConfig().Configure(builder.Entity<WaterSourceProhibitionMarker>());

        base.OnModelCreating(builder);
    }
}
