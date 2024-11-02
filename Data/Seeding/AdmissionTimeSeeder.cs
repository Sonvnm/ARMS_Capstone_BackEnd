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
                   AdmissionTimeId = 1,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 1
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 2,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 1
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 3,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 1
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 4,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 2
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 5,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 2
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 6,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 2
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 7,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 3
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 8,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 3
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 9,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 3
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 10,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 4
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 11,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 4
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 12,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 4
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 13,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 5
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 14,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 5
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 15,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 5
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 16,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 6
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 17,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 6
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 18,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 6
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 19,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 7
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 20,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 7
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 21,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 7
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 22,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 8
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 23,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 8
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 24,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 8
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 25,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 9
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 26,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 9
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 27,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 9
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 28,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 10
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 29,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 10
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 30,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 10
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 31,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 11
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 32,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 11
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 33,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 11
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 34,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 12
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 35,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 12
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 36,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 12
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 37,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 13
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 38,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 13
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 39,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 13
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 40,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 14
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 41,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 14
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 42,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 14
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 43,
                   AdmissionTimeName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 15
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 44,
                   AdmissionTimeName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 15
               },
               new AdmissionTime()
               {
                   AdmissionTimeId = 45,
                   AdmissionTimeName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 15
               }
                );

        }
    }
}
