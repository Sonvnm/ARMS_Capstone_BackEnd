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
            //modelBuilder.Entity<StudentProfile>().HasData(
            //    new StudentProfile()
            //    {
            //        SpId = Guid.Parse("41A2AD7D-1AF6-464E-BBF4-0D18AE664851"),
            //        AccountId = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"),
            //        Fullname = "Nguyễn Đức Anh",
            //        CampusId = "Hanoi",
            //        CitizenIentificationNumber = "038301011111",
            //        CIDate = DateTime.Now,
            //        CIAddress = "HCM",
            //        EmailStudent = "nguyenducanh01.57@gmail.com",
            //        Major1 = "SME",
            //        Major2 = "SME",
            //        PhoneStudent = "0971341555",
            //        Dob = DateTime.Now,
            //        Gender = true,
            //        TypeofStatusMajor1 = TypeofStatusForMajor.Pass,
            //        TypeofStatusMajor2 = TypeofStatusForMajor.Pending,
            //        TypeofStatusProfile = TypeofStatus.Done,
            //        TimeRegister = DateTime.Now,
            //        TypeOfDiplomaMajor1 = TypeOfDiploma.Xet_diem_thi_THPT,
            //        TypeOfDiplomaMajor2 = TypeOfDiploma.Xet_diem_thi_THPT,
            //        PriorityDetailPriorityID = 1,
            //        AIId = 1,
            //    },
            //    new StudentProfile()
            //    {
            //        SpId = Guid.Parse("F2ECD63D-B1C3-4112-AA7E-2634E7AA2DDE"),
            //        Fullname = "Trương Thị Thu",
            //        CampusId = "Hanoi",
            //        Dob = new DateTime(2001, 07, 17, 00, 00, 0),
            //        Gender = false,
            //        Nation ="Kinh",
            //        CitizenIentificationNumber = "038301012222",
            //        CIDate = new DateTime(2024, 05, 04, 00, 00, 0),
            //        CIAddress = "Thanh Hóa",
            //        Province ="Thanh Hóa",
            //        District="Quảng Xương",
            //        Ward ="Quảng Ninh",
            //        SpecificAddress="Số nhà 129",
            //        EmailStudent = "hoaithu1707.25@gmail.com",
            //        PhoneStudent = "0971341555",
            //        PhoneParents = "0971341555",
            //        FullnameParents ="Nguyễn Văn A",
            //        Major1 = "HME",
            //        Major2 = "HGE",
            //        YearOfGraduation =2024,
            //        SchoolName ="Trường THPT A",
            //        RecipientResults = true,
            //        PermanentAddress = true,
            //        ImgCitizenIdentification1 = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fcccd1.jpg?alt=media&token=a72b40d8-50e9-439a-9ded-977a7cf6eed9",
            //        ImgCitizenIdentification2= "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fcccd2.jpg?alt=media&token=36141516-93fa-440d-adaa-55f707818621",
            //        ImgDiplomaMajor1="",
            //        ImgDiplomaMajor2="",
            //        Imgpriority= "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/RegisterAdmission%2Fgiay-to-xac-nhan-doi-tuong-uu-tien-tuyen-sinh.jpg?alt=media&token=704b6826-0b67-4242-ad66-c515deec95fb",
            //        ImgAcademicTranscript1="",
            //        ImgAcademicTranscript2 = "",
            //        ImgAcademicTranscript3 = "",
            //        ImgAcademicTranscript4 = "",
            //        ImgAcademicTranscript5 = "",
            //        ImgAcademicTranscript6 = "",
            //        ImgAcademicTranscript7 = "",
            //        ImgAcademicTranscript8 = "",
            //        ImgAcademicTranscript9 = "",

            //        TypeofStatusMajor1 = TypeofStatusForMajor.Pass,
            //        TypeofStatusMajor2 = TypeofStatusForMajor.Pending,
            //        TypeofStatusProfile = TypeofStatus.Done,
            //        TimeRegister = DateTime.Now,
            //        TypeOfDiplomaMajor1 = TypeOfDiploma.Xet_diem_thi_THPT,
            //        TypeOfDiplomaMajor2 = TypeOfDiploma.Xet_diem_thi_THPT,
            //        PriorityDetailPriorityID = 1,
            //        AIId = 1,
            //    });
                
        }
    }
}