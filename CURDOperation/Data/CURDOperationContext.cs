using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CURDOperation.Models;

namespace CURDOperation.Data
{
    public class CURDOperationContext : DbContext
    {
        public CURDOperationContext (DbContextOptions<CURDOperationContext> options)
            : base(options)
        {
        }

        public DbSet<CURDOperation.Models.Speaker> Speaker { get; set; }
    }
}
