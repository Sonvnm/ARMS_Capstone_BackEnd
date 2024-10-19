using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable(nameof(Account));
            builder.Property(x => x.AvatarURL).IsRequired(false);
            builder.Property(x => x.Gender).IsRequired(false);
            builder.Property(x => x.Fullname).IsRequired(false); 
            builder.Property(x => x.Phone).IsRequired(false);
            builder.Property(x => x.Dob).IsRequired(false);
            builder.Property(x => x.isAccountActive).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.Accounts)
                   .HasForeignKey(x => x.CampusId);

            //builder.HasOne(x => x.StudentProfile)
            //       .WithOne(sp => sp.Account)
            //       .HasForeignKey<StudentProfile>(sp => sp.AccountId);

            #endregion


        }
    }
}
