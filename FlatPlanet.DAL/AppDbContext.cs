
namespace FlatPlanet.DAL
{
    using System.Data.Entity;
    using Entities;
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("appConstring"){ }
        public DbSet<ButtonEventDetails> ButtonEventDetails { get; set; }
    }
}
