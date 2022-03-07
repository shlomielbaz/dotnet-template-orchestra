using Microsoft.EntityFrameworkCore;
using DT.Domain.Entities;

namespace DT.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }
            

            //Called by parameterless ctor Usually Migrations
            var environmentName = Environment.GetEnvironmentVariable("EnvironmentName") ?? "local";
            
            optionsBuilder.UseNpgsql("Host=localhost;Database=orchestra_db;Username=postgres;Password=12345");

            //optionsBuilder.UseSqlServer(
            //    new ConfigurationBuilder()
            //        .SetBasePath(Path.GetDirectoryName(GetType().GetTypeInfo().Assembly.Location))
            //        .AddJsonFile($"appsettings.{environmentName}.json", optional: false, reloadOnChange: false)
            //        .Build()
            //        .GetConnectionString("DalSoftDbContext")
            //);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>()
            .HasMany<User>(o => o.Users)
            .WithOne(u => u.Organization)
            .HasForeignKey(s => s.OrganizationId)
            .OnDelete(DeleteBehavior.Cascade);
        }

        // public DbSet<OrganizationUser> OrganizationUsers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}





