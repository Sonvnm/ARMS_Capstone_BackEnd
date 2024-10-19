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
    internal class StudentProfileConfiguration : IEntityTypeConfiguration<StudentProfile>
    {
        public void Configure(EntityTypeBuilder<StudentProfile> builder)
        {
            builder.ToTable(nameof(StudentProfile));
            builder.HasKey(x => x.SpId);
            builder.Property(x => x.SpId)
               .ValueGeneratedOnAdd();
            builder.Property(x => x.AccountId).IsRequired(false);

            #region config relation
            builder.HasOne(x => x.Campus).WithMany(x => x.StudentProfiles).HasForeignKey(x => x.CampusId);
            builder.HasOne(sp => sp.Account)
               .WithOne(a => a.StudentProfile)
               .HasForeignKey<StudentProfile>(sp => sp.AccountId);

            #endregion
        }
    }
}
