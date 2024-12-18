using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Annies_Cat_Sanctuary.Models;

namespace Annies_Cat_Sanctuary.Data
{
    public class Annies_Cat_SanctuaryContext : DbContext
    {
        public Annies_Cat_SanctuaryContext (DbContextOptions<Annies_Cat_SanctuaryContext> options)
            : base(options)
        {
        }

        public DbSet<Annies_Cat_Sanctuary.Models.Pet> Pet { get; set; } = default!;
    }
}
