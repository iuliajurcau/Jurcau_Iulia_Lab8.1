using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jurcau_Iulia_Lab8._1.Models;

namespace Jurcau_Iulia_Lab8._1.Data
{
    public class Jurcau_Iulia_Lab8_1Context : DbContext
    {
        public Jurcau_Iulia_Lab8_1Context (DbContextOptions<Jurcau_Iulia_Lab8_1Context> options)
            : base(options)
        {
        }

        public DbSet<Jurcau_Iulia_Lab8._1.Models.Book> Book { get; set; }

        public DbSet<Jurcau_Iulia_Lab8._1.Models.Publisher> Publisher { get; set; }

        public DbSet<Jurcau_Iulia_Lab8._1.Models.Category> Category { get; set; }
    }
}
