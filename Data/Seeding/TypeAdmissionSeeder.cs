using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class TypeAdmissionSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public TypeAdmissionSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeAdmission
            modelBuilder.Entity<TypeAdmission>().HasData(
                new TypeAdmission()
                {
                    MajorID = "HME",
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,
                    
                },
                 new TypeAdmission()
                 {
                     MajorID = "HME",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 }
                );

        }
    }
}
