using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Solidarius.Models
{
    public class SolidariusContext : DbContext
    {
        public SolidariusContext (DbContextOptions<SolidariusContext> options)
            : base(options)
        {
        }

        public DbSet<Solidarius.Models.Account> Account { get; set; }
    }
}
