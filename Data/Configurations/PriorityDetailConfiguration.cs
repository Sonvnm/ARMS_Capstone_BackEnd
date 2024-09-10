using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class PriorityDetailConfiguration : IEntityTypeConfiguration<PriorityDetail>
    {
        public void Configure(EntityTypeBuilder<PriorityDetail> builder)
        {
            builder.ToTable(nameof(PriorityDetail));
            builder.HasKey(x => x.PriorityID);
            builder.Property(x => x.PriorityDescription).IsRequired();
            builder.Property(x => x.PriorityName).IsRequired();
            builder.Property(x => x.TypeOfPriority).IsRequired();
        }
    }
}