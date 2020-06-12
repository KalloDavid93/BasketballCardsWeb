using BasketBallCardTrackerWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BasketBallCardTrackerWeb.DAL
{
    public class CardTrackerContext : DbContext
    {
        public CardTrackerContext() : base("CardTrackerContext") 
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
