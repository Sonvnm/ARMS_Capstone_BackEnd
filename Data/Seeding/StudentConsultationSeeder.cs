using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class StudentConsultationSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public StudentConsultationSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed StudentConsultation
            modelBuilder.Entity<StudentConsultation>().HasData(
                new StudentConsultation()
                {
                    StudentConsultationId = Guid.NewGuid(),
                    FullName = "Nguyen Đức Anh",
                    CampusId = "Hanoi",
                    Email = "nguyenducanh01.57@gmail.com",
                    LinkFB = "https://www.facebook.com/profile.php?id=61551770462937",
                    DateReceive = new DateTime(2024, 9, 18, 14, 30, 0),
                    Status = StatusConsultation.Reception,
                    MajorID = "HME",
                    PhoneNumber = "0123456789",
                    
                },
                new StudentConsultation()
                {
                    StudentConsultationId = Guid.NewGuid(),
                    FullName = "Nguyen Đức Anh",
                    CampusId = "Hanoi",
                    Email = "nguyenducanh01.57@gmail.com",
                    LinkFB = "https://www.facebook.com/profile.php?id=61551770462937",
                    DateReceive = new DateTime(2024, 9, 18, 14, 30, 0),
                    Status = StatusConsultation.Uncontact1,
                    MajorID = "HME",
                    PhoneNumber = "0123456789"
                }
                );

        }
    }
}
