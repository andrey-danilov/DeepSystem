using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class DeepContext : DbContext
    {
        //public DbSet<Phone> Phones { get; set; }
        //public DbSet<Order> Orders { get; set; }

        public DeepContext(DbContextOptions<DeepContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
    
}
