using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Jurcau_Iulia_Lab8._1.Data;
using Jurcau_Iulia_Lab8._1.Models;

namespace Jurcau_Iulia_Lab8._1.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Jurcau_Iulia_Lab8._1.Data.Jurcau_Iulia_Lab8_1Context _context;

        public CreateModel(Jurcau_Iulia_Lab8._1.Data.Jurcau_Iulia_Lab8_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
