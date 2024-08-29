using MicroserviceTemplate.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MicroserviceTemplate.Infrastructure;


public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;   

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {      
    }

    public void ApplyMigrations()
    {
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<User> Users { get; set; }

}
