using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AccountSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AccountSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {


            // Seed role data
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>() { Id = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA"), Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<Guid>() { Id = Guid.Parse("D2D63C5B-D09B-4828-8322-F18BA103FE86"), Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole<Guid>() { Id = Guid.Parse("62378687-E16C-4D94-B767-DE9F0BFE9498"), Name = "AdmissionOfficer", NormalizedName = "ADMISSIONOFFICER" },
                new IdentityRole<Guid>() { Id = Guid.Parse("602F7A5F-E0A7-4C00-9DA0-A413BFCFAB3A"), Name = "SchoolService", NormalizedName = "SCHOOLSERVICE" },
                new IdentityRole<Guid>() { Id = Guid.Parse("E5EC8836-E240-4BFC-9BBE-33F2CC7A404D"), Name = "AdmissionCouncil", NormalizedName = "ADMISSIONCOUNCIL" }
            );

            //Seed Account
            modelBuilder.Entity<Account>().HasData(
                new Account()
                {
                    Id = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    UserName = "Administrator",
                    NormalizedUserName = "ADMINISTRATOR",
                    Email = "AdminHaNoi@gmail.com",
                    NormalizedEmail = "ADMINHANOI@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "AdminHn@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CampusId = "Hanoi",
                    Fullname = "Admin Hanoi",
                    isAccountActive = true,
                    TypeAccount = TypeAccount.Account,
                },
                 new Account()
                 {
                     Id = Guid.Parse("5738248D-B40E-4332-9B9E-DEB0ABC8F8DD"),
                     UserName = "AdmissionOfficer",
                     NormalizedUserName = "ADMISSIONOFFICER",
                     Email = "anhtran120786@gmail.com",
                     NormalizedEmail = "ADMISSIONOFFICER@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "AdmissionOfficer@123"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     CampusId = "Hanoi",
                     Fullname = "Admin Officer Hanoi",
                     isAccountActive = true,
                     TypeAccount = TypeAccount.Account,
                 },
                 new Account()
                 {
                     Id = Guid.Parse("17BAF918-D5D2-4628-AAD1-8A4926520676"),
                     UserName = "SchoolService",
                     NormalizedUserName = "SCHOOLSERVICE",
                     Email = "SchoolService@gmail.com",
                     NormalizedEmail = "SCHOOLSERVICE@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "SchoolService@123"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     CampusId = "Hanoi",
                     Fullname = "School Service Hanoi",
                     isAccountActive = true,
                     TypeAccount = TypeAccount.Account,
                 },
                 new Account()
                 {
                     Id = Guid.Parse("AA321FA2-D640-449F-9CF3-D5A14001AA3E"),
                     UserName = "AdmissionCouncil",
                     NormalizedUserName = "ADMISSIONCOUNCIL",
                     Email = "hoaithu1707.25@gmail.com",
                     NormalizedEmail = "ADMISSIONCOUNCIL@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "AdmissionCouncil@123"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     CampusId = "Hanoi",
                     Fullname = "Admission Council Hanoi",
                     isAccountActive = true,
                     TypeAccount = TypeAccount.Account,
                 },
                 new Account()
                 {
                     Id = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"),
                     UserName = "DucAnh",
                     NormalizedUserName = "STUDENT",
                     Email = "nguyenducanh01.57@gmail.com",
                     NormalizedEmail = "NGUYENDUCANH01.57@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "DucAnh@123"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     CampusId = "Hanoi",
                     Fullname = "Nguyễn Đức Anh",
                     StudentCode = "HWE160153",
                     MajorId="HWE",
                     isAccountActive = true,
                     TypeAccount = TypeAccount.RequestAccountAccept,
                 });

            // Seed User in role
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                //Seed admin

                new IdentityUserRole<Guid> { UserId = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
                //seed admin officer
                new IdentityUserRole<Guid> { UserId = Guid.Parse("5738248D-B40E-4332-9B9E-DEB0ABC8F8DD"), RoleId = Guid.Parse("62378687-E16C-4D94-B767-DE9F0BFE9498") },
                //seed school service
                new IdentityUserRole<Guid> { UserId = Guid.Parse("17BAF918-D5D2-4628-AAD1-8A4926520676"), RoleId = Guid.Parse("602F7A5F-E0A7-4C00-9DA0-A413BFCFAB3A") },
                //seed admin council
                new IdentityUserRole<Guid> { UserId = Guid.Parse("AA321FA2-D640-449F-9CF3-D5A14001AA3E"), RoleId = Guid.Parse("E5EC8836-E240-4BFC-9BBE-33F2CC7A404D") },
                ////seed student
                new IdentityUserRole<Guid> { UserId = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"), RoleId = Guid.Parse("D2D63C5B-D09B-4828-8322-F18BA103FE86") }
                );
        }
    }
}
