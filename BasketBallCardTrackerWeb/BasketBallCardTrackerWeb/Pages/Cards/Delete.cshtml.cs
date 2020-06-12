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
    public class DeleteModel : PageModel
    {
        private readonly BasketBallCardTrackerWeb.Data.CardTrackerContext _context;

        public DeleteModel(BasketBallCardTrackerWeb.Data.CardTrackerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Card = await _context.Cards.FindAsync(id);

            if (Card != null)
            {
                _context.Cards.Remove(Card);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
