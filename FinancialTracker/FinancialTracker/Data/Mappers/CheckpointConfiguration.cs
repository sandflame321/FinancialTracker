using FinancialTracker.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTracker.Data.Mappers
{
    public class CheckpointConfiguration : IEntityTypeConfiguration<Checkpoint>
    {
        public void Configure(EntityTypeBuilder<Checkpoint> builder)
        {
            builder.ToTable("Checkpoints");
            builder.HasKey(t => t.Date);

            builder.Property(t => t.portefeuille).IsRequired();
            builder.Property(t => t.spaarrekening).IsRequired();
            builder.Property(t => t.bankkaart).IsRequired();
            builder.Property(t => t.Bedrag).IsRequired();
            builder.Property(t => t.Conclusie).IsRequired();
            builder.Property(t => t.ToekomstZicht).IsRequired();
        }
    }
}
