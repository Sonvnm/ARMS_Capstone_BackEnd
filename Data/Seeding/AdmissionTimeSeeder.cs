using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AdmissionTimeSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AdmissionTimeSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed AdmissionTime
            modelBuilder.Entity<AdmissionTime>().HasData(
               new AdmissionTime()
               {
                   AIId = 1,
                   AdmissionInformationName = "Đợt 1",
                   CampusId ="Hanoi",
                   Year = 2024,
                   StartRegister = new DateTime(2023, 8, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 3, 01, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 4, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 4, 30, 23, 59, 59),
               },
               new AdmissionTime()
               {
                   AIId = 2,
                   AdmissionInformationName = "Đợt 2",
                   CampusId = "Hanoi",
                   Year = 2024,
                   StartRegister = new DateTime(2023, 3, 02, 00, 00, 0),
                   EndRegister = new DateTime(2024, 6, 01, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 7, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 7, 30, 23, 59, 59),
               },
               new AdmissionTime()
               {
                   AIId = 3,
                   AdmissionInformationName = "Đợt 3",
                   CampusId = "Hanoi",
                   Year = 2024,
                   StartRegister = new DateTime(2023, 6, 02, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 9, 01, 23, 59, 59),
               }
                );

        }
    }
}
