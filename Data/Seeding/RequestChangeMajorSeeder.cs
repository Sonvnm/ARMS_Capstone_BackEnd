using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class RequestChangeMajorSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public RequestChangeMajorSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeAdmission
            modelBuilder.Entity<Request>().HasData(
                new Request()
                {
                    RequestID = 1,
                    DateRequest = DateTime.Now,
                    FileReasonRequestChangeMajor ="file",
                    MajorOld = "HAO",
                    MajorNew = "HME",
                    AccountId = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"),
                    Description ="Em muốn chuyển ngành!",
                    Status = TypeofRequestChangeMajor.Inprocess,
                    CampusId ="Hanoi",
                    isRequestChangeMajor = true,
                },
                new Request()
                {
                    RequestID = 2,
                    DateRequest = DateTime.Now,
                    FileReasonRequestChangeMajor = "file",
                    MajorOld = "HAO",
                    MajorNew = "HME",
                    AccountId = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"),
                    Description = "Em muốn chuyển ngành!",
                    Status = TypeofRequestChangeMajor.Inprocess,
                    CampusId = "Hanoi",
                    isRequestChangeMajor = true,
                }
                );

        }
    }
}