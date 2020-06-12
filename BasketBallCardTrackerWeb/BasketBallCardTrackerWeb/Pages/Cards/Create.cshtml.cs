using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasketBallCardTrackerWeb.Data;
using BasketBallCardTrackerWeb.Models;

namespace BasketBallCardTrackerWeb.Pages.Cards
{
    public class CreateModel : PageModel
    {
        private readonly BasketBallCardTrackerWeb.Data.CardTrackerContext _context;

        public CreateModel(BasketBallCardTrackerWeb.Data.CardTrackerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Card Card { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cards.Add(Card);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
