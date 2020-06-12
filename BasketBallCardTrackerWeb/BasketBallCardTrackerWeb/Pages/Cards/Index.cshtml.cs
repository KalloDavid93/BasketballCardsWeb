using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasketBallCardTrackerWeb.Data;
using BasketBallCardTrackerWeb.Models;

namespace BasketBallCardTrackerWeb.Pages.Cards
{
    public class IndexModel : PageModel
    {
        private readonly BasketBallCardTrackerWeb.Data.CardTrackerContext _context;

        public IndexModel(BasketBallCardTrackerWeb.Data.CardTrackerContext context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; }

        public async Task OnGetAsync()
        {
            Card = await _context.Cards.ToListAsync();
        }
    }
}
