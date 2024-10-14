using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class StudentProfileSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public StudentProfileSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeAdmission
            modelBuilder.Entity<StudentProfile>().HasData(
                new StudentProfile()
                {
                    SpId = Guid.NewGuid(),
                    AccountId = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"),
                    Fullname ="Nguyễn Đức Anh",
                    CampusId ="Hanoi",
                    CitizenIentificationNumber ="038301012121",
                    CIDate = DateTime.Now,
                    CIAddress ="HCM",
                    EmailStudent = "nguyenducanh01.57@gmail.com",
                    Major = "HAO",
                    PhoneStudent ="0971341555",
                    Dob = DateTime.Now,
                    Gender = true,
                    
                }
                );

        }
    }
}