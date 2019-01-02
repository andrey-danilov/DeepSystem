using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class DeepContext : DbContext
    {
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceField> ResourceFields { get; set; }

        public DeepContext(DbContextOptions<DeepContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
    
}
