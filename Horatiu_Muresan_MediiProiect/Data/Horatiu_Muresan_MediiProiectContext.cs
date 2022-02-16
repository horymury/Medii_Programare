using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Horatiu_Muresan_MediiProiect.Models;

namespace Horatiu_Muresan_MediiProiect.Models
{
    public class Horatiu_Muresan_MediiProiectContext : DbContext
    {
        public Horatiu_Muresan_MediiProiectContext (DbContextOptions<Horatiu_Muresan_MediiProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Horatiu_Muresan_MediiProiect.Models.Automat> Automat { get; set; }

        public DbSet<Horatiu_Muresan_MediiProiect.Models.Locatie> Locatie { get; set; }

        public DbSet<Horatiu_Muresan_MediiProiect.Models.Produs> Produs { get; set; }
        public DbSet<Horatiu_Muresan_MediiProiect.Models.Class> Class { get; set; }

    }
}
