using Microsoft.EntityFrameworkCore;

namespace data;

public class FishInfoContext(DbContextOptions<FishInfoContext> options) : DbContext(options)
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    optionsBuilder.UseNpgsql("Host=localhost;Database=fish-info;Username=postgres;Password=mitaka1971;Persist Security Info=true;Include Error Detail=true");
  }
}
