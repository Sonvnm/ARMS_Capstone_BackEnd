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
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                 new TypeAdmission()
                 {
                     MajorID = "HME",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_12

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.LienThong,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.LienThong,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 }
                 ,
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THCS,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_5ky
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 }
                 ,
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_lop10_lop11_HK1_12
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HJA",
                     AdmissionTimeId = 31,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                new TypeAdmission()
                {
                    MajorID = "HJA",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HJA",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3ky
                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                }
                ,
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionTimeId = 31,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                }
                //,
                // // 11
                // new TypeAdmission()
                // {
                //     MajorID = "HME",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HME",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HGE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HGE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_12

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HWE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HWE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HWE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3ky
                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HTE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HTE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HTE",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_lop10_lop11_HK1_12
                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HEA",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HEA",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                // }
                // ,
                // new TypeAdmission()
                // {
                //     MajorID = "HEA",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_12
                // },
                // new TypeAdmission()
                // {
                //     MajorID = "HJA",
                //     AdmissionTimeId = 31,
                //     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                // },
                //new TypeAdmission()
                //{
                //    MajorID = "HJA",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.LienThong,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HJA",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HKA",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HKA",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HKA",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HSM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HSM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HSM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HHM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HHM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HHM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HRM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HRM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HRM",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HBT",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HBT",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HBT",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HBS",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HBS",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HBS",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HAO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HAO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HAO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HSO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HSO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HSO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HFO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HFO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                //},
                //new TypeAdmission()
                //{
                //    MajorID = "HFO",
                //    AdmissionTimeId = 31,
                //    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                //    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                //}
            );
        }
    }
}
