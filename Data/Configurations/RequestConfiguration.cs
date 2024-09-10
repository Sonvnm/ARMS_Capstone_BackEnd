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
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.ToTable(nameof(Request));
            builder.HasKey(x => x.RequestID);
            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.DateRequest).IsRequired();
            builder.Property(x => x.FileReasonRequestChangeMajor).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            #region config relation
            builder.HasOne(x => x.Account)
                   .WithMany(c => c.RequestChangeMajors)
                   .HasForeignKey(x => x.AccountId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.RequestChangeMajors)
                   .HasForeignKey(x => x.CampusId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.MajorN)
                   .WithMany(c => c.RequestChangeMajorsN)
                   .HasForeignKey(x => x.MajorNew).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.MajorO)
                   .WithMany(c => c.RequestChangeMajorsO)
                   .HasForeignKey(x => x.MajorOld).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}