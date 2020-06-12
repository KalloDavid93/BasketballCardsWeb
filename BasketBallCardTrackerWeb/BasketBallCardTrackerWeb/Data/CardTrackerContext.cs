using BasketBallCardTrackerWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketBallCardTrackerWeb.Data
{
    public class CardTrackerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CardCollection> Collections { get; set; }
        public DbSet<Card> Cards { get; set; }

        public CardTrackerContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CardTrackerDB");
        }
    }
}
