using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Flowers.Models;

namespace Flowers.Data
{
    public class MvcFlowersContext : DbContext
    {
        public MvcFlowersContext(DbContextOptions<MvcFlowersContext> options)
            : base(options)
        {
        }

        public DbSet<Flower> Flower { get; set; }
    }
}
