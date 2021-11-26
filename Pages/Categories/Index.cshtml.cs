﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jurcau_Iulia_Lab8._1.Data;
using Jurcau_Iulia_Lab8._1.Models;

namespace Jurcau_Iulia_Lab8._1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Jurcau_Iulia_Lab8._1.Data.Jurcau_Iulia_Lab8_1Context _context;

        public IndexModel(Jurcau_Iulia_Lab8._1.Data.Jurcau_Iulia_Lab8_1Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
