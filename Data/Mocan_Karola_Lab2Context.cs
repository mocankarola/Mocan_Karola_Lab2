using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mocan_Karola_Lab2.Models;

namespace Mocan_Karola_Lab2.Data
{
    public class Mocan_Karola_Lab2Context : DbContext
    {
        public Mocan_Karola_Lab2Context (DbContextOptions<Mocan_Karola_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mocan_Karola_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
