﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jurcau_Iulia_Lab8._1.Data;
using Jurcau_Iulia_Lab8._1.Models;

namespace Jurcau_Iulia_Lab8._1.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Jurcau_Iulia_Lab8._1.Data.Jurcau_Iulia_Lab8_1Context _context;

        public DetailsModel(Jurcau_Iulia_Lab8._1.Data.Jurcau_Iulia_Lab8_1Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
