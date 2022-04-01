using AngularBaseLoja.Data.Extension;
using AngularBaseLoja.Data.Mappings;
using AngularBaseLoja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularBaseLoja.Data.Context
{
    public class ExpandedDbContext : DbContext
    {
        public ExpandedDbContext(DbContextOptions<ExpandedDbContext> options) : base(options)
        {
        }

        #region "DbSet"
        public DbSet<User>? Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }

    }
}
