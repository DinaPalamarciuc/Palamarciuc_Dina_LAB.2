using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Palamarciuc_Dina_LAB._2.Models;

namespace Palamarciuc_Dina_LAB._2.Data
{
    public class Palamarciuc_Dina_LAB_2Context : DbContext
    {
        public Palamarciuc_Dina_LAB_2Context (DbContextOptions<Palamarciuc_Dina_LAB_2Context> options)
            : base(options)
        {
        }

        public DbSet<Palamarciuc_Dina_LAB._2.Models.Book> Book { get; set; } = default!;
    }
}
