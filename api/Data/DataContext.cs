
using Microsoft.EntityFrameworkCore;
using TxPanthers.Api.Models;
using api.Components.PlayerManager;


namespace TxPanthers.Api.Data
{
public class DataContext : DbContext
{
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("AppConnection"));

        }

        public DbSet<MemberDetails> Members {get; set;}
        public DbSet<PlayerDetails> Players {get; set;}
    }

}