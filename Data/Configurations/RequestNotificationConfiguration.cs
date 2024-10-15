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
    public class RequestNotificationConfiguration : IEntityTypeConfiguration<RequestNotification>
    {
        public void Configure(EntityTypeBuilder<RequestNotification> builder)
        {
            builder.ToTable(nameof(RequestNotification));
            builder.HasKey(x => x.RequestId);
            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.HasOne(x => x.Account)
                  .WithMany(c => c.RequestNotifications)
                  .HasForeignKey(x => x.AccountId);
        }
    }
}
