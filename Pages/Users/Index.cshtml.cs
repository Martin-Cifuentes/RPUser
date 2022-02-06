#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RPUser.Data;
using RPUser.Models;

namespace RPUser.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly RPUser.Data.RPUserContext _context;

        public IndexModel(RPUser.Data.RPUserContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/

            //_context.User.Add(User);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Tableview");
        }
    }
}
