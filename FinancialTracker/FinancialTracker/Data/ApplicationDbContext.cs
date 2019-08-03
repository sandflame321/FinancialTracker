using System;
using System.Collections.Generic;
using System.Text;
using FinancialTracker.Data.Mappers;
using FinancialTracker.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinancialTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Checkpoint> Checkpoints { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CheckpointConfiguration());
        }
    }
}
