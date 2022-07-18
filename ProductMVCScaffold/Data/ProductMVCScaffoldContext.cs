using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMVCScaffold.Models;

namespace ProductMVCScaffold.Data
{
    public class ProductMVCScaffoldContext : DbContext
    {
        public ProductMVCScaffoldContext (DbContextOptions<ProductMVCScaffoldContext> options)
            : base(options)
        {
        }

        public DbSet<ProductMVCScaffold.Models.Product> Product { get; set; } = default!;
    }
}
