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
    public class DetailsModel : PageModel
    {
        private readonly BasketBallCardTrackerWeb.Data.CardTrackerContext _context;

        public DetailsModel(BasketBallCardTrackerWeb.Data.CardTrackerContext context)
        {
            _context = context;
        }

        public Card Card { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Card = await _context.Cards.FirstOrDefaultAsync(m => m.CardId == id);

            if (Card == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
