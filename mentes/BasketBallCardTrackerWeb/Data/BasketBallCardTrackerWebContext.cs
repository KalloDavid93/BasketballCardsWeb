using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasketBallCardTrackerWeb.Models;

namespace BasketBallCardTrackerWeb.Data
{
    public class BasketBallCardTrackerWebContext : DbContext
    {
        public BasketBallCardTrackerWebContext (DbContextOptions<BasketBallCardTrackerWebContext> options)
            : base(options)
        {
        }

        public DbSet<BasketBallCardTrackerWeb.Models.Card> Card { get; set; }
    }
}
