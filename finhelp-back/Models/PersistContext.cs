using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finhelp_back.Models
{
    public class PersistContext : DbContext
    {
        public PersistContext()
        {

        }

        public PersistContext(DbContextOptions<PersistContext> options):base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Categories.Categories> Categories { get; set; }
    }
}
