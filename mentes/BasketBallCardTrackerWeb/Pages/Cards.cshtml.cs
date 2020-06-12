using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasketBallCardTrackerWeb.Data;
using BasketBallCardTrackerWeb.Models;

namespace BasketBallCardTrackerWeb.Pages
{
    public class CardsModel : PageModel
    {
        private readonly BasketBallCardTrackerWeb.Data.BasketBallCardTrackerWebContext _context;

        public CardsModel(BasketBallCardTrackerWeb.Data.BasketBallCardTrackerWebContext context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; }

        public async Task OnGetAsync()
        {
            Card = await _context.Card.ToListAsync();
        }
    }
}
